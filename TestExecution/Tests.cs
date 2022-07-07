using NUnit.Framework;
using RestBDDAutomationPack;
using System.Net;

namespace TestExecution
{
    public class Tests
    {
        public HttpStatusCode statuscode;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPets()
        {
            var api = new Actions();
            var res = api.GetPets();
            Assert.AreEqual(111, res.id,"Pet Id is not as expected");
            Assert.AreEqual("name", res.category.name, "Category name is not as expected");
            Assert.AreEqual("name", res.name, "Name is not as expected");
            Assert.AreEqual("OK", res.status, "Status is not as expected");
            Assert.AreEqual("url", res.photoUrls, "Photo Urls are not as expected");
            
        }

        [Test]
        public void CreatePet()
        {
            string payload = @"{
                                ""id"" :1111
                                }";
            var api = new Actions();
            var res = api.CreatePets(payload);

            Assert.AreEqual(1111, res.status, "Status is not as expected");
            Assert.AreEqual(1111, res.id, "Id is not as expected");
            Assert.AreEqual(1111, res.name, "Name is not as expected");
        }

        [Test]
        public void CreatePetUsingPut()
        {
            string payload = @"{
                                ""id"" :1111
                                }";
            var api = new Actions();
            var res = api.CreatePets(payload);

            Assert.AreEqual(1111, res.status, "Status is not as expected");
            Assert.AreEqual(1111, res.id, "Id is not as expected");
            Assert.AreEqual(1111, res.name, "Name is not as expected");
        }

        [Test]
        public void DeletePet()
        {
            string payload = @"{
                                ""id"" :1111
                                }";
            var api = new Actions();
            var res = api.DeleteRequest(payload);

            Assert.AreEqual(200, res.StatusCode, "Status is not as expected");
            
        }



    }
}