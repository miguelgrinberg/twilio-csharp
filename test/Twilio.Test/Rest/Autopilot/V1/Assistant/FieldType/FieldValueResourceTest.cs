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
using Twilio.Rest.Autopilot.V1.Assistant.FieldType;

namespace Twilio.Tests.Rest.Autopilot.V1.Assistant.FieldType
{

    [TestFixture]
    public class FieldValueTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldValues/UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldValueResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues/UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type_sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"language\": \"language\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"value\": \"value\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"synonym_of\": null}"
                                     ));

            var response = FieldValueResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldValues",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldValueResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"field_values\": [],\"meta\": {\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues?Language=language&PageSize=50&Page=0\",\"page_size\": 50,\"previous_page_url\": null,\"key\": \"field_values\",\"page\": 0,\"next_page_url\": null,\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues?Language=language&PageSize=50&Page=0\"}}"
                                     ));

            var response = FieldValueResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"field_values\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues/UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type_sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"language\": \"language\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"value\": \"value\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"synonym_of\": \"UCbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb\"}],\"meta\": {\"first_page_url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues?Language=language&PageSize=50&Page=0\",\"page_size\": 50,\"previous_page_url\": null,\"key\": \"field_values\",\"page\": 0,\"next_page_url\": null,\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues?Language=language&PageSize=50&Page=0\"}}"
                                     ));

            var response = FieldValueResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldValues",
                ""
            );
            request.AddPostParam("Language", Serialize("language"));
            request.AddPostParam("Value", Serialize("value"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldValueResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "language", "value", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://autopilot.twilio.com/v1/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldTypes/UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/FieldValues/UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"field_type_sid\": \"UBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"language\": \"language\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"value\": \"value\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sid\": \"UCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"synonym_of\": \"UCbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb\"}"
                                     ));

            var response = FieldValueResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "language", "value", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Autopilot,
                "/v1/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldTypes/UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/FieldValues/UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FieldValueResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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

            var response = FieldValueResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}