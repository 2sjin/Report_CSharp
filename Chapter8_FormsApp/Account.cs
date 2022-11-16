namespace WindowsFormsApp2 {
    class Account {
        public string Id { get; }
        public string Pw { get; }

        public Account(string id, string pw) {
            Id = id;
            Pw = pw;
        }
    }
}
