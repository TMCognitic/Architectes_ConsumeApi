using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsumeApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:7288/api/");

            //    using(HttpResponseMessage responseMessage = client.GetAsync("todo").Result)
            //    {
            //        //responseMessage.EnsureSuccessStatusCode(); // << si le code n'est pas 2xx EXCEPTION!!!!
            //        // ou
            //        if (responseMessage.IsSuccessStatusCode) // << condition => pas d'exception
            //        {
            //            string json = responseMessage.Content.ReadAsStringAsync().Result;
            //            Todo[]? items = JsonSerializer.Deserialize<Todo[]>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //            Console.WriteLine(json);

            //            if (items is not null)
            //            {
            //                foreach(Todo item in items)
            //                {
            //                    Console.WriteLine($"{item.Id} - {item.Title}");                                
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Code erreur reçu : {(int)responseMessage.StatusCode}");
            //            Console.WriteLine($"Message : {responseMessage.ReasonPhrase}");
            //        }
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:7288/api/");

            //    CreateTodoForm form = new CreateTodoForm() { Title = "Test from Console" };

            //    HttpContent httpContent = JsonContent.Create(form);
            //    //HttpContent httpContent = JsonContent.Create(new { Title = "Test from Console" });

            //    using (HttpResponseMessage responseMessage = client.PostAsync("todo", httpContent).Result)
            //    {
            //        //responseMessage.EnsureSuccessStatusCode(); // << si le code n'est pas 2xx EXCEPTION!!!!
            //        // ou
            //        if (responseMessage.IsSuccessStatusCode) // << condition => pas d'exception
            //        {
            //            string json = responseMessage.Content.ReadAsStringAsync().Result;
            //            Todo? item = JsonSerializer.Deserialize<Todo>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //            Console.WriteLine(json);

            //            if (item is not null)
            //            {
            //                Console.WriteLine($"{item.Id} - {item.Title}");                            
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Code erreur reçu : {(int)responseMessage.StatusCode}");
            //            Console.WriteLine($"Message : {responseMessage.ReasonPhrase}");
            //        }
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:7288/api/");

            //    using (HttpResponseMessage responseMessage = client.PutAsync($"todo/cloture/{1}", null).Result)
            //    {
            //        //responseMessage.EnsureSuccessStatusCode(); // << si le code n'est pas 2xx EXCEPTION!!!!
            //        // ou
            //        if (responseMessage.IsSuccessStatusCode) // << condition => pas d'exception
            //        {
            //            Console.WriteLine($"Modification effectuée");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Code erreur reçu : {(int)responseMessage.StatusCode}");
            //            Console.WriteLine($"Message : {responseMessage.ReasonPhrase}");
            //        }
            //    }
            //}

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7288/api/");

                using (HttpResponseMessage responseMessage = client.DeleteAsync($"todo/{1}").Result)
                {
                    //responseMessage.EnsureSuccessStatusCode(); // << si le code n'est pas 2xx EXCEPTION!!!!
                    // ou
                    if (responseMessage.IsSuccessStatusCode) // << condition => pas d'exception
                    {
                        Console.WriteLine($"Suppression effectuée");
                    }
                    else
                    {
                        Console.WriteLine($"Code erreur reçu : {(int)responseMessage.StatusCode}");
                        Console.WriteLine($"Message : {responseMessage.ReasonPhrase}");
                    }
                }
            }
        }
    }
}
