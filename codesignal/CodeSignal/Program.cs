using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // imageRotate();
            // sudoku2();
            // isCryptSolution();
        }

        static void imageRotate()
        {
            int[][] mat = new int[4][];

            mat[0] = new int[4] {1, 2, 3, 4};
            mat[1] = new int[4] {5, 6, 7, 8};
            mat[2] = new int[4] {9, 10, 11, 12};
            mat[3] = new int[4] {13, 14, 15, 16};
            
            int l = mat.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (j == 0)
                        Console.Write("\n");
                    
                    Console.Write(mat[i][j] + " " );


                }
            }

            for (int x = 0; x < l / 2; x++)
            {
                for (int y = x; y < l - x - 1; y++)
                {
                    int newY = l - 1 - y;
                    int newX = l - 1 - x;
                    
                    int temp = mat[x][y]; 
                    mat[x][y] = mat[newY][x]; 
                    mat[newY][x] = mat[newX][newY]; 
                    mat[newX][newY] = mat[y][newX]; 
                    mat[y][newX] = temp; 

                }
            }

            Console.WriteLine();

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (j == 0)
                        Console.Write("\n");
                    
                    Console.Write(mat[i][j] + " ");
                }
            }
        }

        static void sudoku2() {

        char[][] grid = {
            new char[] { '.', '.', '.', '1', '4', '.', '.', '2', '.'},
            new char[] {'.', '.', '6', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
            new char[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},
            new char[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
            new char[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
            new char[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
            };

            Dictionary<char, bool> hashtable;
            // check columns
            for (var i = 0; i < 9; i++)
            {
                hashtable = new Dictionary<char, bool>();
                for (var j = 0; j < 9; j++)
                {
                    var value = grid[i][j];
                    if (value.Equals('.'))
                    {
                        continue;
                    } 
                    
                    if (hashtable.ContainsKey(value))
                    {
                        Console.WriteLine(false);
                    }
                    hashtable.Add(value, true);
                }
            }

            // check rows
            for (var i = 0; i < 9; i++)
            {
                hashtable = new Dictionary<char, bool>();
                for (var j = 0; j < 9; j++)
                {
                    var value = grid[j][i];
                    if (value.Equals('.'))
                    {
                        continue;
                    }

                    if (hashtable.ContainsKey(value))
                    {
                        Console.WriteLine(false);
                    }

                    hashtable.Add(value, true);
                }
            }

            // check squares
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    hashtable = new Dictionary<char, bool>();

                    for (var m = 0; m < 3; m++)
                    {
                        for (var n = 0; n < 3; n++)
                        {
                            var value = grid[i * 3 + m][j * 3 + n];
                            if (value.Equals('.'))
                            {
                                continue;
                            }

                            if (hashtable.ContainsKey(value))
                            {
                                Console.WriteLine(false);
                            }

                            hashtable.Add(value, true);
                        }
                    }
                }
            }
            Console.WriteLine(true);
        }

        static void isCryptSolution() {

            string[] crypt = { 
                "AAAAAAAAAAAAAA", 
                "BBBBBBBBBBBBBB", 
                "CCCCCCCCCCCCCC"
            };
            char[][] solution = {
                new char[] { 'A', '1'},
                new char[] { 'B', '2'}, 
                new char[] { 'C', '3'}
            };

            //string[] crypt = {"SEND", "MORE", "MONEY"};
            // char[][] solution = { 
            //     new char[] {'O', '0'}, 
            //     new char[] {'M', '1'},
            //     new char[] {'Y', '2'},
            //     new char[] {'E', '5'},
            //     new char[] {'N', '6'},
            //     new char[] {'D', '7'},
            //     new char[] {'R', '8'},
            //     new char[] {'S', '9'}
            // };

            List<long> num = new List<long>();
            
            for (int i = 0; i < crypt.Length; i++) {
                string n = "";
                for (int j = 0; j < crypt[i].Length; j++) {
                    for (int x = 0; x < solution.Length; x++) {
                        if (crypt[i][j] == solution[x][0]) {
                            n += solution[x][1];
                        }
                    }
                }
                if (n.StartsWith('0') && n.Length > 1) {
                    Console.WriteLine(false);
                }
                
                bool success = Int64.TryParse(n, out Int64 result);

                if (success) {
                    num.Add(result);
                } else {
                    Console.WriteLine(false);
                }
            }
            
            num.ForEach(i => Console.WriteLine("{0}\t", i));



            if (num.ElementAt(0) + num.ElementAt(1) == num.ElementAt(2)) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
