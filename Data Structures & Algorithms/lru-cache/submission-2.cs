public class LRUCache
{
    public Node? head;
    public Node? tail;
    public int capacity;
    public int currentcapacity;
    public Dictionary<int, Node> hashtable;

    public LRUCache(int capacity)
    {
        hashtable = new Dictionary<int, Node>();
        this.capacity = capacity;
    }
    public void MoveToHead(Node node)
    {
        if(head == node)
        {
            return;
        }
        else if (tail == node)
        {
            tail = node.prev;
            node.prev!.next = null;
        }
        else
        {
            node.prev!.next = node.next;
            node.next!.prev = node.prev;
        }
        node.prev = null;
        node.next = head;
        head!.prev = node;
        head = node;
    }
    public int Get(int key)
    {
        if (hashtable != null && head != null && hashtable.TryGetValue(key, out Node? node))
        {
            if(head == node)
            {
                return node.data;
            }
            MoveToHead(node);
            return head.data;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if(hashtable != null && hashtable.TryGetValue(key, out Node? node))
        {
            MoveToHead(node);
            node.data = value;
        }
        else
        {
            Node newnode = new Node();
            hashtable.Add(key, newnode);
            newnode.data = value;
            newnode.key = key;
            if(head == null)
            {
                head = newnode;
                tail = newnode;
                currentcapacity++;
            }
            else
            {
                head!.prev = newnode;
                newnode.next = head;
                if(currentcapacity == capacity)
                {
                    hashtable.Remove(tail!.key);
                    tail = tail!.prev;
                    tail!.next = null;
                }
                else
                {
                    currentcapacity++;
                }
                head = newnode;
            }
        }
    }
}

public class Node
{
    public int data;
    public int key;
    public Node? prev;
    public Node? next;
}


