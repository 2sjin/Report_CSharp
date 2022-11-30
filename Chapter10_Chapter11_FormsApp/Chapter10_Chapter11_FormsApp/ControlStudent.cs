namespace Chapter10_Chapter11_FormsApp {
    class ControlStudent {
        Student std = new Student();

        public void SetStudent(string id, string name, string email) {
            std.Id = id;
            std.Name = name;
            std.Email = email;
        }

        public Student GetStudent() {
            return std;
        }
    }
}
