Stack_and_Queue.queue stack = new Stack_and_Queue.queue();
int option = 1;
while (option != 2)
{
    Console.WriteLine("Enter data to add in Stack: ");
    int data = Convert.ToInt32(Console.ReadLine());
    stack.add_Data(data);
    Console.WriteLine("1.Add Data\n2.Exit");
    option = Convert.ToInt32(Console.ReadLine());
}
