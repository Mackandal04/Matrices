    public class Matrices(){
        public static int [,] Suma(int[,] m1 , int[,] m2){
            int[,] sum = new int[m1.GetLength(0),m1.GetLength(1)];
            for(int i = 0; i < m1.GetLength(0); i ++){
                for(int j=0;j<m1.GetLength(1);j++){
                    sum[i,j] = m1[i,j] + m2[i,j];
                }
            }
            return sum;
        }

        public static int[,] Multi(int[,]m1,int[,]m2){
        int[,] res=new int[m1.GetLength(0),m2.GetLength(1)];
        for(int i = 0;i<m1.GetLength(0);i++){
            for(int j = 0 ;j<m2.GetLength(1);j++)
            {//Recorre las filas
            for(int x=0; x<m1.GetLength(1);x++){
            res[i,j] += m1[i,x] * m2[x,j];
            }
        }
    } 
        return res;
    }

    public static int Diago(int[,]m){
        int diagonalsuma = 0 ;
        for(int j =0; j < m.GetLength(0);j++){
            diagonalsuma = diagonalsuma + m[j,j];
        }
        return diagonalsuma;
    } 

    public static int[,] Traspuesta(int[,]m){
        int[,] tras = new int[m.GetLength(1),m.GetLength(0)];
        for(int j=0; j<m.GetLength(1); j ++){
            for(int i = 0;i<m.GetLength(0);i++){
                tras[j,i]=m[i,j];
            }
        }
        return tras ;
    }

    public static bool Simetrica(int[,]m){
        bool whatis;
        for(int i = 0; i < m.GetLength(0); i ++){
            for(int j = 0 ; j <m.GetLength(1); j ++ ){
                if(m[i,j] != m[j,i]){
                    whatis = false;
                    return whatis;
                }
                continue;
            }
        }
        whatis = true;
                return whatis;
    }

    public static int[,] Ceros(int[,]m)
    {
            int [,]copia = new int[m.GetLength(0),m.GetLength(1)];

            for(int i=0;i<m.GetLength(0);i++){
                for(int j=0;j<m.GetLength(1);j++){
                    copia[i,j]=m[i,j];
                }
            }
            // int[,] copia = m;

            for( int i = 0; i <m.GetLength(0); i ++)
            {
                for( int j =0; j <m.GetLength(1); j ++)
                {
                    if(m[i,j]==0)
                    {
                        for( int k = 0; k <m.GetLength(1); k ++)
                        {
                            copia[k,j] = 0;
                            
                        }
                        for (int l = 0; l <m.GetLength(0); l ++)
                        {
                            copia[i,l] = 0 ;
                        }
                    }
                } 
            }
        return copia;
    }
}



