using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TräningsProgram
{
    public class Databas
    {
        string server = "127.0.0.1";
        string databas = "Personalize_training";
        string username = "user_1";
        string password = "ABC123";
        string connectionString;

        
        public Databas()
        {
                connectionString =
                    "Server=" + server + ";" +
                    "Database=" + databas + ";" +
                    "UserID=" + username + ";" +
                    "Password=" + password + ";";

        }
        public List<Exercise> GetAllExercises()
        {
            List<Exercise> exercises = new List<Exercise>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Exercises;";
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Exercise exercise = new Exercise((int)reader["Exercise_id"], (string)reader["Exercise_name"]);
                exercises.Add(exercise);
            }
            connection.Close();

            return exercises;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
           
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();
            string query = "SELECT * FROM Users;";
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User((int)reader["User_id"], (string)reader["User_name"], (string)reader["User_password"]);
                users.Add(user);
            }
            connection.Close();
               
            return users;
        }
        public List<Muscel_Group> GetAllMuscelGroups()
        {
            List<Muscel_Group> MuscelGroups = new List<Muscel_Group>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Muscel_Group;";
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Muscel_Group muscelGroup = new Muscel_Group((int)reader["Muscel_Group_id"], (string)reader["Muscel_Group_name"]);
                MuscelGroups.Add(muscelGroup);
            }
            connection.Close();

            return MuscelGroups;
        }
        
        public List< Program> GetAllPrograms(User user)
        {
            List<Program> Programs = new List<Program>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Program WHERE User_ID = 1 OR user_id = " + user.Id + ";";
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Program Program = new Program((int)reader["Program_Id"], (string)reader["Program_name"]);
                Programs.Add(Program);
            }
            connection.Close();

            return Programs;

        }
        public List<Muscel_Group> GetEffectedMuscelGroups(List<Exercise> newWorkout)
        {
            List< Muscel_Group> EffectedMuscelGroups = new List< Muscel_Group>();
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            foreach (Exercise exercise in newWorkout)
            {


                string query = "SELECT Muscel_Group_Name FROM See_Exercise_Muscel_Group WHERE Exercise_Id = " + exercise.Id + ";";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader()) 

                while (reader.Read())
                {
                    Muscel_Group muscelGroup = new Muscel_Group((string)reader["Muscel_Group_Name"]);
                    EffectedMuscelGroups.Add(muscelGroup);
                }
            }
            connection.Close();

            return EffectedMuscelGroups;
        }

    
        public void AddWorkout(User user, string programName, List<WorkoutExercises>workoutExercises)
        {
            Program newprogram = null;
            List<Program> programs = new List<Program>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "CALL Add_program( \"" + programName + "\", " + user.Id + " );";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            query = "SELECT * FROM program WHERE program_Name = \"" + programName + "\";";
            
            command = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = command.ExecuteReader())

                while (reader.Read())
            {
                newprogram = new Program ((int)reader["program_id"], (string)reader["program_name"]);
                programs.Add(newprogram);
            }

            
            foreach (WorkoutExercises we in workoutExercises)
            {
                List<Exercise> exercise = GetAllExercises();
                int id=0;
                for (int i = 0; i < exercise.Count; i++)
                {
                    if (we.ExerciseName == exercise[i].Name)
                    {
                        id = exercise[i].Id; break;

                    }
                }

                
                int duration = we.duration;
                int reps = we.reps;
                int weight = we.weight; 
                int incline = we.incline;

                query = $"CALL Add_Workout ({newprogram.Id}, {id}, {duration}, {reps}, {weight}, {incline});";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();

        }
        public List<WorkoutExercises> GetWorkout(Program program)
        {
            List<WorkoutExercises> Workout = new List<WorkoutExercises>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

                string query = "SELECT * FROM See_Workout WHERE Program_Id = " + program.Id + ";";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        WorkoutExercises we = new WorkoutExercises ((string)reader["Exercise_Name"], (int)reader["E_Time"], (int)reader["Reps"], (int)reader["Weight"], (int)reader["Incline"]) ;
                        Workout.Add(we);
                    }
            
            connection.Close();

            return Workout;
        }
        public void AddExercise(string exerciseName, List<Muscel_Group> groups)
        {
            Exercise NewExercise=null;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query ="CALL Add_Exercise (\""+ exerciseName +"\");";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

            List<Exercise> exercises = GetAllExercises();

            foreach (Exercise exercise in exercises)
            {
                if (exerciseName == exercise.Name)
                {
                    NewExercise = exercise;
                }
            }
            AddMuscelGroupToExercise(NewExercise, groups);

        }
        public void AddMuscelGroupToExercise(Exercise exercise, List<Muscel_Group> groups)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            foreach (Muscel_Group group in groups)
            {
                string query = "CALL Add_Muscel_Group_to_Exercise(" + exercise.Id + ", " + group.Id +");";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            connection.Close ();
        }
        public void RemoveExercise (Exercise exercise)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM exercises WHERE Exercise_id = " + exercise.Id + ";";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            query = "DELETE FROM Exercise_Muscel_Group WHERE Exercise_id = " + exercise.Id + ";";
            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            query = "DELETE FROM Workout WHERE Exercise_id = " + exercise.Id + ";";
            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close ();
        }
    }
}
