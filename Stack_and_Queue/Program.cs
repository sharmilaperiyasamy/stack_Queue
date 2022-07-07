Stack_and_Queue.stack stack = new Stack_and_Queue.stack();
Stack_and_Queue.queue queue = new Stack_and_Queue.queue();

Console.WriteLine("Which Data Structure you want: \n1.Stack\n2.Queue\nEnter your choice:");
int ds = Convert.ToInt32(Console.ReadLine());
switch (ds)
{
    case 1:
        Console.WriteLine("Stack Operations : \n0.Exit\n1.Push the Data into the stack\n2.Pop Data from the stack\n3.Display Peak\nEnter your choice:");
        int option = Convert.ToInt32(Console.ReadLine());
        while (option != 0)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter data to add in Stack: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    stack.add_Data(data);
                    break;
                case 2:
                    stack.pop_data();
                    break;
                case 3:
                    stack.peak_data();
                    break;
                default:
                    Console.WriteLine("Invalid Chioce.");
                    break;
            }
            Console.WriteLine("Stack Operations : \n0.Exit\n1.Push the Data into the stack\n2.Pop Data from the stack\n3.Display Peak\nEnter your choice:");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }
break;
    case 2:
        Console.WriteLine("Queue Operations\n0.Exit\n1.Enqueue\n2.Dequeue\n3.Display\nEnter your choice:");
int option2 = Convert.ToInt32(Console.ReadLine());
while (option2 != 0)
{
    switch (option2)
    {
        case 1:
            Console.WriteLine("Enter data to add into the Stack: ");
            int data = Convert.ToInt32(Console.ReadLine());
            queue.Enqueue(data);
            break;
        case 2:
            queue.Dequeue();
            break;
        case 3:
            queue.Display();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
    Console.WriteLine("Queue Operations\n0.Exit\n1.Enqueue\n2.Dequeue\n3.Display\nEnter your choice:");
    option2 = Convert.ToInt32(Console.ReadLine());
}
break;
}
