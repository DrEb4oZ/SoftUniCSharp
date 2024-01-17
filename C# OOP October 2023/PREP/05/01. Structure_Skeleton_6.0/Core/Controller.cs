using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Repositories.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private IRepository<IStudent> students;
        private IRepository<ISubject> subjects;
        private IRepository<IUniversity> universities;
        private string[] subjectTypes = { "EconomicalSubject", "HumanitySubject", "TechnicalSubject" };
        public Controller()
        {
            students = new StudentRepository();
            subjects = new SubjectRepository();
            universities = new UniversityRepository();
        }
        public string AddStudent(string firstName, string lastName)
        {
            string studentName = firstName + " " + lastName;
            if (students.FindByName(studentName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedStudent, firstName, lastName);
            }

            IStudent studentToAdd = new Student(students.Models.Count + 1, firstName, lastName);

            students.AddModel(studentToAdd);
            return string.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, students.GetType().Name);
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            if (!subjectTypes.Contains(subjectType))
            {
                return string.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }

            if (subjects.FindByName(subjectName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedSubject, subjectName);
            }

            ISubject subjectToAdd = null;

            if(subjectType == "EconomicalSubject")
            {
                subjectToAdd = new EconomicalSubject(subjects.Models.Count + 1, subjectName);
            }

            else if (subjectType == "HumanitySubject")
            {
                subjectToAdd = new HumanitySubject(subjects.Models.Count + 1, subjectName);
            }

            else if (subjectType == "TechnicalSubject")
            {
                subjectToAdd = new TechnicalSubject(subjects.Models.Count + 1, subjectName);
            }

            subjects.AddModel(subjectToAdd);

            return string.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);

        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if(universities.FindByName(universityName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedUniversity, universityName);
            }
            List<int> requiredSubjectsID = new List<int>();
            foreach (var subject in requiredSubjects)
            {
                int requiredSubjectID = subjects.Models.FirstOrDefault(s => s.Name == subject).Id;
                requiredSubjectsID.Add(requiredSubjectID);
            }
            IUniversity universityToAdd = new University(universities.Models.Count + 1, universityName, category, capacity, requiredSubjectsID.AsReadOnly());
            universities.AddModel(universityToAdd);
            return string.Format(OutputMessages.UniversityAddedSuccessfully, universityName, universities.GetType().Name);
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] studentNameTokens = studentName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (students.FindByName(studentName) == null)
            {
                return string.Format(OutputMessages.StudentNotRegitered, studentNameTokens[0], studentNameTokens[1]);
            }

            if (universities.FindByName(universityName) == null)
            {
                return string.Format(OutputMessages.UniversityNotRegitered, universityName);
            }

            IUniversity university = universities.FindByName(universityName);
            IStudent student = students.FindByName(studentName);

            foreach (var subject in university.RequiredSubjects)
            {
                if (!student.CoveredExams.Contains(subject))
                {
                    return string.Format(OutputMessages.StudentHasToCoverExams, studentName, universityName);
                }
            }

            if (student.University == university)
            {
                return string.Format(OutputMessages.StudentAlreadyJoined, student.FirstName, student.LastName, universityName);
            }

            student.JoinUniversity(university);
            return string.Format(OutputMessages.StudentSuccessfullyJoined, student.FirstName, student.LastName, universityName);
        }

        public string TakeExam(int studentId, int subjectId)
        {
            if (students.FindById(studentId) == null)
            {
                return string.Format(OutputMessages.InvalidStudentId);
            }

            if (subjects.FindById(subjectId) == null)
            {
                return string.Format(OutputMessages.InvalidSubjectId);
            }

            IStudent student = students.FindById(studentId);
            ISubject subject = subjects.FindById(subjectId);
            if (student.CoveredExams.Any(ce => ce == subjectId))
            {
                return string.Format(OutputMessages.StudentAlreadyCoveredThatExam, student.FirstName, student.LastName, subject.Name);
            }

            student.CoverExam(subject);

            return string.Format(OutputMessages.StudentSuccessfullyCoveredExam, student.FirstName, student.LastName, subject.Name);
            
        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = universities.FindById(universityId);

            var studentsInUniversity = students.Models.Where(s => s.University == university);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {studentsInUniversity.Count()}");
            sb.AppendLine($"University vacancy: {university.Capacity - studentsInUniversity.Count()}");

            return sb.ToString().TrimEnd();

        }
    }
}
