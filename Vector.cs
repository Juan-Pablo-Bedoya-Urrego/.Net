using System.Text;

class Vector{
    Random r = new Random();
    int[] llenarVector(int[] l) {
        for(int i = 0; i < l.Length; i++){
            l[i] = r.Next(0,10);
        }
        return l;
    }

    void mostrar(int []l){
        foreach(int i in l){
            Console.WriteLine(i);
        }
    }

    int[] ordenadoDeMayorAMenor(int[] l){
        int largo = l.Length;
        for(int i=0; i < largo - 1;i++){
            
            for(int j = 0; j < largo - i - 1;j++){
                if(l[j] < l[j+1]){
                    int ax = l[j];
                    l[j] = l[j+1];
                    l[j+1] = ax;
                }
            }
        }
        return l;
    }

    int[] menorAMayor(int[] l){
        int largo = l.Length;
        for(int i=0; i < largo - 1;i++){
            
            for(int j = 0; j < largo - i - 1;j++){
                if(l[j] > l[j+1]){
                    int ax = l[j];
                    l[j] = l[j+1];
                    l[j+1] = ax;
                }
            }
        }
        return l;
    }

    int mayor(int[] l){
        int mayor = 0;
        for(int i=0; i < l.Length; i++){
            if(l[i] > mayor){
                mayor = l[i];
            }
        }
        return mayor;
    }

    int menor(int[] l){
        int menor = l[0];
        for(int i=0; i < l.Length; i++){
            if(l[i] < menor){
                menor = l[i];
            }
        }
        return menor;
    }

    int segundoMayor(int[] l){
        int mayor = 0;
        int segundo = 0;
        for(int i = 0; i < l.Length;i++){
            if(l[i] > mayor){
                segundo = mayor;
                mayor = l[i];
            }else if(l[i] > segundo && l[i] != mayor){
                segundo = l[i];
            }
        }

        return segundo;
    }

    public void vec(int[] l) {
        llenarVector(l);
        mostrar(l);
        ordenadoDeMayorAMenor(l);
        Console.WriteLine("Mayor a menor");
        mostrar(l);
        menorAMayor(l);
        Console.WriteLine("Menor a mayor");
        mostrar(l);
        Console.WriteLine("Mayor");
        Console.WriteLine(mayor(l));
        Console.WriteLine("Menor");
        Console.WriteLine(menor(l));
        Console.WriteLine("Segundo Mayor");
        Console.WriteLine(segundoMayor(l));
    }

    public string palabraAlReves(string palabra){
        char[] palabraChars = palabra.ToCharArray();
        int longuitud = palabra.Length;
        for(int i = 0; i < longuitud /2;i++){
            char c = palabraChars[i];
            palabraChars[i] = palabraChars[longuitud - 1 - i];
            palabraChars[longuitud - 1 - i] = c;
        }
        string palabraReves = new string(palabraChars);
        return palabraReves;
    }

    public Boolean capicua(string palabra){
        char[] palabraChars = palabra.ToCharArray();
        int longuitud = palabra.Length;
        for(int i = 0; i < longuitud / 2; i++){
            if(palabraChars[i] != palabraChars[longuitud - 1- i]){
                return false;
            }
        }
        return true;
    }
    public string rellenoEntre(string palabra){
        StringBuilder resultado = new StringBuilder();
        int longuitud = palabra.Length;
        for(int i = 0; i < longuitud;i++){
            resultado.Append(palabra[i]);
            if (i < longuitud -1){
                resultado.Append("-");
            }
        }
        return resultado.ToString();
    }
}