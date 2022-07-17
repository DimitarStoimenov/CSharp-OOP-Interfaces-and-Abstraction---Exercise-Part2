namespace BorderControll.Core
{
    using BorderControll.Contracts;
    using BorderControll.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<IIdentifiable> repository;

        public Engine()
        {
            this.repository = new List<IIdentifiable>();
        }

        public void Run()
        {
            string command = Console.ReadLine();
            
            while (command != "End")
            {
                string[] input = command.Split();

                ValidationInput(input);
                command = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();
            string[] fakeIds = repository.Where(x => x.Id.EndsWith(fakeId)).Select(s => s.Id).ToArray();
            PrintFakeIds(fakeIds);

        }

        private void PrintFakeIds(string[] fakeIds)
        {
            foreach (var item in fakeIds)
            {
                Console.WriteLine(item);
            }
        }

        private void ValidationInput(string[] input)
        {
            IIdentifiable member = null;
            if (input.Length == 3)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string id = input[2];

                member = new Citizen(name, age, id);
                
            }
            else
            {
                string model = input[0];
                string id = input[1];

                member = new Robot(model, id);
            }
            repository.Add(member);
        }
    }
}
