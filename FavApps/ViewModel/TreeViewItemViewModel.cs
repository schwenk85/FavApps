using System.Collections.ObjectModel;

namespace FavAppsStarter.ViewModel
{
    /// <summary>
    ///     Base class for all ViewModel classes displayed by TreeViewItems.
    ///     This acts as an adapter between a raw data object and a TreeViewItem.
    /// </summary>
    public class TreeViewItemViewModel : ObservableObject
    {
        private static readonly TreeViewItemViewModel DummyChild = new TreeViewItemViewModel();

        private bool _isExpanded;
        private bool _isSelected;
        
        /// <summary>
        ///     This is used to create the DummyChild instance.
        /// </summary>
        private TreeViewItemViewModel()
        {
        }

        protected TreeViewItemViewModel(TreeViewItemViewModel parent, bool lazyLoadChildren)
        {
            Parent = parent;

            Children = new ObservableCollection<TreeViewItemViewModel>();

            if (lazyLoadChildren)
            {
                Children.Add(DummyChild);
            }
        }

        /// <summary>
        ///     Returns the logical child items of this object.
        /// </summary>
        public ObservableCollection<TreeViewItemViewModel> Children { get; }

        public TreeViewItemViewModel Parent { get; }

        /// <summary>
        ///     Returns true if this object's Children have not yet been populated.
        /// </summary>
        public bool HasDummyChild => Children.Count == 1 && Children[0] == DummyChild;

        /// <summary>
        ///     Gets/sets whether the TreeViewItem associated with this object is expanded.
        /// </summary>
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                SetProperty(ref _isExpanded, value);

                // Expand all the way up to the root.
                if (_isExpanded && Parent != null)
                {
                    Parent.IsExpanded = true;
                }

                // Lazy load the child items, if necessary.
                if (HasDummyChild)
                {
                    Children.Remove(DummyChild);
                    LoadChildren();
                }
            }
        }

        /// <summary>
        ///     Gets/sets whether the TreeViewItem associated with this object is selected.
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        /// <summary>
        ///     Invoked when the child items need to be loaded on demand.
        ///     Subclasses can override this to populate the Children collection.
        /// </summary>
        protected virtual void LoadChildren()
        {
        }
    }
}