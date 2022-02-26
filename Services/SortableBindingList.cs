using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Services
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private readonly Dictionary<Type, PropertyComparer<T>> comparers;
        private bool isSorted;
        private ListSortDirection listSortDirection;
        private PropertyDescriptor propertyDescriptor;

        public SortableBindingList() : base(new List<T>())
        {
            try
            {
                comparers = new Dictionary<Type, PropertyComparer<T>>();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public SortableBindingList(IEnumerable<T> enumeration) : base(new List<T>(enumeration))
        {
            try
            {
                this.comparers = new Dictionary<Type, PropertyComparer<T>>();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSorted;
        protected override PropertyDescriptor SortPropertyCore => this.propertyDescriptor;
        protected override ListSortDirection SortDirectionCore => this.listSortDirection;
        protected override bool SupportsSearchingCore => true;

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            try
            {
                var itemsList = (List<T>)Items;

                var propertyType = property.PropertyType;
                PropertyComparer<T> comparer;
                if (!comparers.TryGetValue(propertyType, out comparer))
                {
                    comparer = new PropertyComparer<T>(property, direction);
                    comparers.Add(propertyType, comparer);
                }

                comparer.SetPropertyAndDirection(property, direction);
                itemsList.Sort(comparer);

                propertyDescriptor = property;
                listSortDirection = direction;
                isSorted = true;

                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        protected override void RemoveSortCore()
        {
            try
            {
                isSorted = false;
                propertyDescriptor = base.SortPropertyCore;
                listSortDirection = base.SortDirectionCore;

                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        protected override int FindCore(PropertyDescriptor property, object key)
        {
            var count = Count;
            try
            {
                for (var i = 0; i < count; ++i)
                {
                    T element = this[i];
                    if (property.GetValue(element).Equals(key)) return i;
                }
                return -1;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return -1;
            }
        }
    }
}
