namespace FormExceptionExample {
    class Student {
        public double Kor { get; }
        public double Eng { get; }
        public double Math { get; }

        public Student(int kor = 0, int eng = 0, int math = 0) {
            Kor = kor;
            Eng = eng;
            Math = math;
        }

        public string GetGrade() {
            switch ((int)(GetAvg() / 10)) {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        }

        public double GetAvg() {
            double avg = (this.Kor + this.Eng + this.Math) / 3;
            return avg;
        }
    }
}
