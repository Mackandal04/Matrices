int[,] a = new int[,] {{0,2,},{6,8}};
int[,] b = new int[,] {{1,3,},{5,6}};
int[,] c = Matrices.Suma(a,b);
//int[,] c = Matrices.Ceros(a);
for(int i =0; i <c.GetLength(1); i++ ){
    for(int j=0; j<c.GetLength(0);j++){
        Console.Write(c[i,j] + " ");
    }System.Console.WriteLine();
}