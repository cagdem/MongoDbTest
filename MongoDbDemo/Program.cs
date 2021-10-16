using System;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //PersonModel person = new PersonModel 
            //{ 
            //    FirstName = "Caglar", 
            //    LastName = "Demir",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "Deneme",
            //        City = "Ankara",
            //        State = "Emek",
            //        ZipCode = "06490"
            //    }
            //};

            //db.InsertRecord("Users", person);

            //var recs = db.LoadRecords<PersonModel>("Users");

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName} {rec.LastName}");
            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);

            //    }
            //    Console.WriteLine();
            //}

            var recs = db.LoadRecords<NameModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");

                Console.WriteLine();
            }

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("7c1990e6-cf2f-40b7-a74f-4e3358510267"));

            //oneRec.DateOfBirth = new DateTime(1995, 6, 21,0,0,0,0,DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);



        }
    }
}
