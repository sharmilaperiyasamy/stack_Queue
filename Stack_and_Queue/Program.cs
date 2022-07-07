Stack_and_Queue.queue stack = new Stack_and_Queue.queue();
Console.WriteLine("Stack Operations\n0.Exit\n1.Push the Data into the stack\n2.Pop Data from the stack\n3.Display Peak\nEnter your choice:");
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
    Console.WriteLine("Stack Operations\n0.Exit\n1.Push the Data into the stack\n2.Pop Data from the stack\n3.Display Peak\nEnter your choice:");
    option = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");
}
