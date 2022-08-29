using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Owner.Properties
{
    class Player:Person
    {
        private int _rating;
        private int _value;
        private char _foot; // 'r' - right, 'l' - left , 'b' - both
        private int _salary;
        private string _football_club;
        private int _seniority;
        private int _height; // in cm
        private int _weight; // in kg

        public Player(string first_name, string last_name, char gender
            , int age, Date birthday,int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight) :base(first_name, last_name, gender, birthday)
        {
            this._rating = rating;
            this._value = value;
            this._foot = foot;
            this._salary = salary;
            this._football_club = football_club;
            this._seniority = seniority;
            this._height = height;
            this._weight = weight;
        }

        public int getRating() { return this._rating; }
        public int getValue() { return this._value; }
        public char getFoot() { return this._foot; }
        public int getSalary() { return this._salary; }
        public string getFootballClub() { return this._football_club; }
        public int getSeniority() { return this._seniority; }
        public int getHeight() { return this._height; }
        public int getWeight() { return this._weight; }

        public void setRating(int rating) { this._rating = rating; }
        public void setValue(int value) { this._value = value; }
        public void setFoot(char foot) { this._foot = foot; }
        public void setSalary(int salary) { this._salary = salary; }
        public void setSeniority(int seniority) { this._seniority = seniority; }
        public void setFootballClub(string football_club) { this._football_club = football_club; }
        public void setHeight(int height) { this._height = height; }
        public void setWeight(int weight) { this._weight = weight; }

        public override void special_ability()
        {
            throw new NotImplementedException();
        }

        public string dataPlayer()
        {
            return "Player Card :\n\n" +
            "First Name: " + getFirstName() + "\n" +
            "Last Name: " + getLastName() + "\n" +
            "Gender: " + getGender() + "\n" +
            "Age: " + getAge() + "\n" +
            "Rating: " + _rating + "\n" +
            "Football Club: " + _football_club + "\n" +
            "Seniority: " + _seniority + "/n" +
            "Foot: " + _foot + "\n" +
            "Salary: " + _salary + "\n" +
            "Value: " + _value + "\n" +
            "Height: " + _height + "\n" +
            "Weight: " + _weight + "\n";
        }


    }
}
