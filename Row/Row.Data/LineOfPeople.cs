namespace RowData;

public class LineOfPeople
{
    public Node? firstNode {get; set;}

    public void AddToFront(Person person)
    {
        if (firstNode == null)
        {
            firstNode = new Node();
            firstNode.person = person;
            return;
        }
        else
        {
            Node node = firstNode;

            while(true)
            {
                if (node.nextNode == null)
                {
                    node.nextNode = new Node();
                    node.nextNode.person = person;
                    return;
                }
                else
                {
                    node = node.nextNode;
                }
            }
            
        } 
    }

    public void Clear()
    {
        firstNode = null;
    }
}
