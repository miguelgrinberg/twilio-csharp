/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Autopilot.V1.Assistant.Task;

namespace Twilio.Tests.Rest.Autopilot.V1.Assistant.Task 
{

    [TestFixture]
    public class FieldTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Fields/UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields/UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type\": \"field_type\"}"
                                     ));

            var response = FieldResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Fields",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"fields\": [],\"meta\": {\"page\": 0,\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields?PageSize=50&Page=0\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields?PageSize=50&Page=0\",\"key\": \"fields\",\"next_page_url\": null,\"previous_page_url\": null,\"page_size\": 50}}"
                                     ));

            var response = FieldResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"fields\": [{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields/UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type\": \"field_type\"}],\"meta\": {\"page\": 0,\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields?PageSize=50&Page=0\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields?PageSize=50&Page=0\",\"key\": \"fields\",\"next_page_url\": null,\"previous_page_url\": null,\"page_size\": 50}}"
                                     ));

            var response = FieldResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Fields",
                ""
            );
            request.AddPostParam("FieldType", Serialize("FieldType"));
            request.AddPostParam("UniqueName", Serialize("UniqueName"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "FieldType", "UniqueName", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Fields/UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type\": \"field_type\"}"
                                     ));

            var response = FieldResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "FieldType", "UniqueName", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Fields/UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = FieldResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}