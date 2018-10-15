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
    public class SampleTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Samples/UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SampleResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples/UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"language\": \"language\",\"tagged_text\": \"tagged_text\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"source_channel\": null}"
                                     ));

            var response = SampleResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Samples",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SampleResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"samples\": [],\"meta\": {\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples?PageSize=50&Page=0\",\"previous_page_url\": null,\"key\": \"samples\",\"next_page_url\": null,\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples?PageSize=50&Page=0\",\"page\": 0,\"page_size\": 50}}"
                                     ));

            var response = SampleResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"samples\": [{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples/UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"language\": \"language\",\"tagged_text\": \"tagged_text\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"source_channel\": \"sms\"}],\"meta\": {\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples?PageSize=50&Page=0\",\"previous_page_url\": null,\"key\": \"samples\",\"next_page_url\": null,\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples?PageSize=50&Page=0\",\"page\": 0,\"page_size\": 50}}"
                                     ));

            var response = SampleResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Samples",
                ""
            );
            request.AddPostParam("Language", Serialize("Language"));
            request.AddPostParam("TaggedText", Serialize("TaggedText"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SampleResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "Language", "TaggedText", client: twilioRestClient);
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
                                         "{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples/UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"language\": \"language\",\"tagged_text\": \"tagged_text\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"source_channel\": \"alexa\"}"
                                     ));

            var response = SampleResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "Language", "TaggedText", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Samples/UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SampleResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Tasks/UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Samples/UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"language\": \"language\",\"tagged_text\": \"tagged_text\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"source_channel\": \"alexa\"}"
                                     ));

            var response = SampleResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Tasks/UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Samples/UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SampleResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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

            var response = SampleResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}