namespace Composite
{
    public class Category : IComparable<Category>
    {
        public int CompareTo(Category? other)
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        }
    }

    public class Composite<T> where T : IComparable<T>, new()
    {
        //Leaf: içerisine başka element eklenemeyecek olan elementtir.
        //Non-Leaf: içerisine başka element eklenebilecek olan element - Node'dur.
        public T Node { get; set; } = new T();
        public List<Composite<T>> Children { get; set; } = new List<Composite<T>>();

        public Composite<T> Add(T child)
        {
            Composite<T> newComposite = new Composite<T>() { Node = child };
            Children.Add(newComposite);
            return newComposite;
        }

        public static void Show(int level, Composite<T> composite, TreeView treeView)
        {
            string line = new string('*', level);
            //TreeNode node = treeView.Nodes.Add($"{line}{composite.Node}");
            TreeNode treeNode = new TreeNode(composite.Node.ToString());
            addItemToNode(composite, treeNode);
            treeView.Nodes.Add(treeNode);
        }

        private static void addItemToNode(Composite<T> composite, TreeNode node)
        {
            TreeNode childNode = node.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                addItemToNode(item, childNode);

            }
            //node.Nodes.Add(item.ToString());
        }
    }
}
