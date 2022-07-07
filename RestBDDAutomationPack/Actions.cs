using RestSharp;
using RestBDDAutomationPack.Helper;

namespace RestBDDAutomationPack
{
    public class Actions
    {
        private RestBDDAutomationPack.Helper.Helper helper;

        public Actions()
        {
            helper = new RestBDDAutomationPack.Helper.Helper();
        }

                   
            public Pet GetPets()
            {
                var client = helper.SetUrl("https://petstore.swagger.io/v2/pet/111");
                var request = helper.CreateGetRequest();
                request.RequestFormat = DataFormat.Json;
                var response = helper.GetResponse(client, request);
                var pet = HandleContent.GetContent<Pet>(response);


                return pet;
            }

            public CreatePetRes CreatePets(string payload)
            {
                var client = helper.SetUrl("https://petstore.swagger.io/v2/pet");
                var request = helper.CreatePostRequest(payload);
                var response = helper.GetResponse(client, request);
                var createpet = HandleContent.GetContent<CreatePetRes>(response);


                return createpet;
            }

        public CreatePetRes CreatePutRequest(string payload)
        {
            var client = helper.SetUrl("https://petstore.swagger.io/v2/pet");
            var request = helper.CreatePostRequest(payload);
            var response = helper.GetResponse(client, request);
            var createpet = HandleContent.GetContent<CreatePetRes>(response);


            return createpet;
        }

        public RestResponse DeleteRequest(string payload)
        {
            var client = helper.SetUrl("https://petstore.swagger.io/v2/pet");
            var request = helper.CreatePostRequest(payload);
            var response = helper.GetResponse(client, request);
            
            return response;
        }
    }
}

