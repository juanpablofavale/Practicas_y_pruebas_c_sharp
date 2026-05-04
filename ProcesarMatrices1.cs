Console.WriteLine("Proyecto guiado: desarrollo de estruicturas foreach e if-elseif-else para trabajos con matrices");

//array de alumnos
//array de notas de alumnos
/* establecer nota según promedio por alumno
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
*/

// initialize variables - graded assignments 
int examAssignments = 5;

int[] notasSophia = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] notasAndrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] notasEmma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasLogan = new int[] { 90, 95, 87, 88, 96, 96 };
int[] notasBecky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] notasChris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] notasEric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] notasGregor = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] nombreAlumnos = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

/*
int[] notasSophia = [ 90 , 86 , 87 , 98 , 100 , 94 , 90 ];
int[] notasAndrew = [ 92 , 89 , 81 , 96 , 90 , 89 ];
int[] notasEmma = [ 90 , 85 , 87 , 98 , 68 , 89 , 89 , 89 ];
int[] notasLogan = [ 90 , 95 , 87 , 88 , 96 , 96 ];

string[] nombreAlumnos = [ "Sophia" , "Andrew" , "Emma" , "Logan" ];
*/

int[] notasAlumno = new int[examAssignments];

Console.WriteLine("Student\t\tGrade\n");
	
foreach (string alumno in nombreAlumnos)
{
	if (alumno == "Sophia") 
		notasAlumno = notasSophia;

	else if (alumno == "Andrew")
		notasAlumno = notasAndrew;

	else if (alumno == "Emma")
		notasAlumno = notasEmma;

	else if (alumno == "Logan")
		notasAlumno = notasLogan;

	else if (alumno == "Becky")
		notasAlumno = notasBecky;

	else if (alumno == "Chris")
		notasAlumno = notasChris;

	else if (alumno == "Eric")
		notasAlumno = notasEric;

	else if (alumno == "Gregor")
		notasAlumno = notasGregor;

	else
		continue;


	int alumnoSum = 0;

	int cantidadNotas = 0;

	decimal alumnoScore = 0;

	foreach (int nota in notasAlumno)
	{
		if (cantidadNotas < examAssignments)
		{
			alumnoSum += nota;
		}
		else
		{
			alumnoSum += (nota / 10);
		}
		cantidadNotas++;
	}

	alumnoScore = (decimal)alumnoSum / examAssignments;

	string letraNota;

	if ( alumnoScore >= 97 )
		letraNota = "A+";

	else if ( alumnoScore >= 93 )
		letraNota = "A";

	else if ( alumnoScore >= 90 )
		letraNota = "A-";

	else if ( alumnoScore >= 87 )
		letraNota = "B+";

	else if ( alumnoScore >= 83 )
		letraNota = "B";

	else if ( alumnoScore >= 80 )
		letraNota = "B-";

	else if ( alumnoScore >= 77 )
		letraNota = "C+";

	else if ( alumnoScore >= 73 )
		letraNota = "C";

	else if ( alumnoScore >= 70 )
		letraNota = "C-";

	else if ( alumnoScore >= 67 )
		letraNota = "D+";

	else if ( alumnoScore >= 63 )
		letraNota = "D";

	else if ( alumnoScore >= 60 )
		letraNota = "D-";

	else
		letraNota = "F";

	Console.WriteLine($"{alumno}:\t\t" + alumnoScore + $"\t{letraNota}");
}
