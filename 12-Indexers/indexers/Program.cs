
namespace indexers{

    class Program{
        public static void Main(string[] args)
        {
            // intor to index
            // like array or string
            int []arr = {1,2,3,4,5};
            // System.Console.WriteLine(arr[1]); // print value at the index 1 -> 1;

            IP ip = new IP("127.0.0.5");
            IP ip2 = new IP(127,0,0,3);
            System.Console.WriteLine(ip.Address());
            System.Console.WriteLine(ip2.Address());


            // note: this is not real sudoko, it just an example
            int [,]matrix = {
                {8,3,9,1,2,4,6,5,7},
                {1,2,3,4,5,6,7,8,9},
                {9,8,7,6,5,4,3,2,1},
                {3,6,5,4,8,9,7,1,2},
                {8,6,4,7,5,2,1,3,9},
                {7,5,6,4,2,1,9,3,8},
                {6,7,8,9,5,4,3,1,2},
                {4,2,1,7,5,6,3,9,8},
                {5,2,1,3,9,8,6,4,7},
            };

            Sudoko sudoko = new(matrix);
            sudoko[5,4] = 10;
            System.Console.WriteLine(sudoko[5,4]); // 7


        }

    }


    class IP{

        private readonly int []ip_segments = new int[4];

        // add indexer
        public int this [int index]
        { 
            get{
                return ip_segments[index];
            }
            set{
                ip_segments[index] = value;
            }
        }
        public IP(string ip)
        {
            string []segs = ip.Split(".");
            for (int i = 0; i < segs.Length; i++)
                ip_segments[i] = int.Parse(segs[i]);
        }

        public IP(int seg1,int seg2,int seg3,int seg4)
        {
            ip_segments[0] = seg1;
            ip_segments[1] = seg2;
            ip_segments[2] = seg3;
            ip_segments[3] = seg4;
        }

        public string Address()=> string.Join(".",ip_segments);
    }

    class Sudoko{
        private int [,] matrix;
        public Sudoko(int[,] matrix)
        {
            this.matrix = matrix;
        }

        // add indexer
        public int this [int row,int col] { 
            get{ 
                if(row<1 || row > matrix.GetLength(0))
                    return -1;
                if(col<1 || row > matrix.GetLength(1))
                    return -1;
                return matrix[row-1,col-1];
            }
            set {
                if(value<1 || value > matrix.GetLength(0))
                    return;
                matrix[row-1,col-1] = value;
            }
        }
    }
}

