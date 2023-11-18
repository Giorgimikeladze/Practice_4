

int numb;
Console.Write("Enter integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed && numb>=1)
{
    int sum = 0;
    for (int i = 0; i <= numb; i++) {
        if (i%2==1) {
            sum += i;
        }
        
    }
    Console.WriteLine($"sum of the odd numbers from 1 to {numb} is: {sum}");
    
   
}
else { 

}