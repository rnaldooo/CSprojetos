//First lets read the xml..
List<treenode> parents = new List<treenode>();
List<treenode> nodes = new List<treenode>(); //Create a storage for xml nodes
string[] temp = new string[256]; //Helper for organizing nodes
XmlTextReader tr = new XmlTextReader(File.Open(@"C:/Users/Default/Desktop/example.xml", FileMode.Open)); //Create Xml Reader
            while (tr.Read())
            {
                if (tr.NodeType == XmlNodeType.Element && !tr.HasValue)
                    parents.Add(new TreeNode("<" + tr.Name + ">")); //Parent nodes
                if (tr.NodeType == XmlNodeType.Element && tr.HasValue)
                    temp[tr.LineNumber] = "<" + tr.Name + ">"; //Child nodes                   
                if (tr.NodeType == XmlNodeType.Text)
                    nodes.Add(new TreeNode((temp[tr.LineNumber] ?? "") + tr.Value));
            }
            tr.Close();
 
            ImageList list = null; // Implement your images here...
treeView1.ImageList = list;
 
            TreeNode[] collection = new TreeNode[parents.Count];
            for (int i = 0; i<parents.Count; i++)
            {
                collection[i] = new TreeNode(parents[i].Text, nodes.ToArray()); //Combine parents and child nodes
collection[i].ImageIndex = 1; //Index of imagelist to show
            }
 
            treeView1.Nodes.AddRange(collection); //Add the collection to your treeview