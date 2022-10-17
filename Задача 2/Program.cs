// Написно конечно на коленке и не совсем так как должно быть, он все же
// По хрошему я должен написать написать условия при которых из координат возможно построить фигуру, 
// условия при которых только Х или только Y должен умножаться на коэффициент или и X и Y вместе 
Console.Write("Введите коэффициент маштабирования: ");
var K = Convert.ToDouble(Console.ReadLine());
double[,] table1 = new double[2, 4];
double[,] table = new double[2, 4];
for(int i = 0; i < 2; ++i) 
        {
            for(int j=0; j < 4; ++j) 
            {   
                if ( i == 0)
                {
                    Console.Write($"Ведите X{j}: ");
                    table[i,j] = Convert.ToDouble(Console.ReadLine());
                }            
                else if ( i == 1)
                {
                  Console.Write($"Ведите Y{j}: "); 
                  table[i,j] = Convert.ToDouble(Console.ReadLine()); 
                }
                table1[i,j] = table[i,j] * K;   
            }                      
        }
 
        Console.WriteLine("Координаты исходных вершин: ");
        Console.WriteLine($"({table[0 , 0]}, {table[1 , 0]}) ({table[0 , 1]}, {table[1 , 1]}) ({table[0 , 2]}, {table[1 , 2]}) ({table[0 , 3]}, {table[1 , 3]})"); 
        Console.WriteLine($"При K = {K} координаты вершин в маштабе: ");
        Console.WriteLine($"({table1[0 , 0]}, {table1[1 , 0]}) ({table1[0 , 1]}, {table1[1 , 1]}) ({table1[0 , 2]}, {table1[1 , 2]}) ({table1[0 , 3]}, {table1[1 , 3]})");


