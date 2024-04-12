using ConsoleApp3;

Node<int> node = new Node<int>(9);
Tree<int> tree = new Tree<int>(node);
Node<int> node2 = new Node<int>(10);
node.addChild(new Node<int>(57));
node.addChild(node2);
node2.addChild(new Node<int>(345));
node2.addChild(new Node<int>(23));
node.addChild(new Node<int>(56));
node = new Node<int>(878);
node.addChild(new Node<int>(90));
node2.addChild(node);
tree.print();
