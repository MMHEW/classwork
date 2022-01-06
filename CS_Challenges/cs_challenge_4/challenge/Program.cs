List<string> list = new List<string>();

string flag = "yes";

while(flag[0] == 'y'){

    System.Console.WriteLine("please inut an item you wish to add to the list");

    list.Add(Console.ReadLine());

    System.Console.WriteLine("Do you wish to continue? 'y' or 'yes' to continue" );

    flag = Console.ReadLine();

    flag.ToLower();
}
System.Console.WriteLine("you added the following to the list: ");
foreach(string i in list){
    System.Console.WriteLine(i);
}


System.Console.WriteLine("thanks for coming to my ted talk");