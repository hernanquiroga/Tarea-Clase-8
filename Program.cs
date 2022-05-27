//Ejercicio

//Crear un programa que cumpla con los siguientes pasos

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios


Console.Write("Ingrese la cantidad de filas: ");
// Determina las columnas
int filas = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la cantidad de columnas: ");
// Determina las columnas
int columnas = Convert.ToInt32(Console.ReadLine());

int[,] numeros = new int[filas, columnas];

double[,] promedios = new double[filas, columnas];

//Cantidad de filas
int lengthFilas = numeros.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Recorremos columnas

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();

    Console.WriteLine($"Columna : {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de la fila :{fila + 1}: ");
        numeros[fila, columna] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("------------------------------------------");

// Imprime los valores de la matriz

foreach (int item in numeros){
   Console.WriteLine(item + "\t");
}




