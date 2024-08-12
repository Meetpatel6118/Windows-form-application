//Course course1;

Course[] csCourseArray = new Course[100];

int numOfCourses = 0;


Console.WriteLine("**********************  Welcome to the Computer Science Department  **********************");
int choice;
char ans;
do
{
    do
    {
        Console.WriteLine(" choose 1 for adding a new course or 2 for searching for a course or 3 for printing all courses and 4 to Exit");
        choice = Convert.ToInt32(Console.ReadLine());
        if (!(choice > 0 && choice <= 4))
        {
            Console.WriteLine("invalide input");
        }

    } while (!(choice > 0 && choice <= 4));

    switch (choice)
    {

        case 1:

            if (numOfCourses <= 99)
            {
                Course newCourse = new Course();

                Console.WriteLine("what is the course's id ");
                newCourse.id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("wht is the couse's name");
                newCourse.name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("what is the number of hours of the course");
                newCourse.numOfHoursOfTheCourse = Convert.ToInt32(Console.ReadLine());
                if (lookupCourse(newCourse.id) == -1)
                {
                    addCourse3(newCourse);
                }
                else
                {
                    Console.WriteLine("The new course cannot be added since it is a duplicate");
                }

            }
            else
            {
                Console.WriteLine("The new course cannot be added since it exceeded the length");
            }
            break;

        case 2:
            Console.WriteLine("what is the course's id you are looking for?");
            string id = Convert.ToString(Console.ReadLine());
            int indexFound = lookupCourse(id);
            if (indexFound == -1)
            {
                Console.WriteLine("The course was not found");
            }
            else
            {
                Console.WriteLine($"The course was found @index {indexFound}");
            }
            break;
        case 3:
            for (int i = 0; i < numOfCourses; i++)
            {
                printCourse(i);
            }
            break;
        case 4:
            Console.WriteLine("Good Bye");
            break;
    }
    Console.WriteLine("Would you like to repeat y/n?");
    ans = Convert.ToChar(Console.ReadLine());
} while (ans.Equals('y'));




// implentation 1


void addCourse1()
{

    Course newCourse = new Course();

    Console.WriteLine("what is the course's id ");
    newCourse.id = Convert.ToString(Console.ReadLine());

    Console.WriteLine("wht is the couse's name");
    newCourse.name = Convert.ToString(Console.ReadLine());


    Console.WriteLine("what is the number of hours of the course");
    newCourse.numOfHoursOfTheCourse = Convert.ToInt32(Console.ReadLine());

    csCourseArray[numOfCourses] = newCourse;
    numOfCourses++;

}


// implentation 2
void addCourse2(string courseId, string courseName, int courseHours)
{
    Course newCourse = new Course();
    newCourse.id = courseId;
    newCourse.name = courseName;
    newCourse.numOfHoursOfTheCourse = courseHours;

    csCourseArray[numOfCourses] = newCourse;
    numOfCourses++;

}

// implentation 3

void addCourse3(Course aCourse)
{
    csCourseArray[numOfCourses] = aCourse;
    numOfCourses++;
}



//b
int lookupCourse(string courseId)
{

    for (int i = 0; i < csCourseArray.Length; i++)
    {
        if (courseId.Equals(csCourseArray[i].id))
        {
            return i;
        }

    }
    return -1;

}

// c

void printCourse(int indexInfo)
{
    Console.WriteLine($"{csCourseArray[indexInfo].id}+{csCourseArray[indexInfo].name}+{csCourseArray[indexInfo].numOfHoursOfTheCourse}");

}





struct Course
{
    public string id;
    public string name;
    public int numOfHoursOfTheCourse;
}
