using System.ComponentModel;

namespace CRUD_Buttons
{
    public partial class InsertButtonComponent : Component
    {
        public InsertButtonComponent()
        {
            InitializeComponent();
        }

        public InsertButtonComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
