




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
#pragma warning disable 219 //The variable 'lower_limit' is assigned but its value is never used
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Test geoJSON conversion

    [TestFixture]
    public class GeoGeojson : YamlTestFixture {

        public GeoGeojson (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiI0IiwiT3JpZ2luYWwiOiJyLmdlb2pzb24oeydjb29yZGluYXRlcyc6WzAsIDBdLCAndHlwZSc6J1BvaW50J30pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5nZW9qc29uKHIuaGFzaE1hcChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoMEwsIDBMKSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6WzAsIDBdLCAndHlwZSc6J1BvaW50J30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgMEwpKS53aXRoKFwidHlwZVwiLCBcIlBvaW50XCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/geojson.yaml, #4
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 0], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point");
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiI2IiwiT3JpZ2luYWwiOiJyLmdlb2pzb24oeydjb29yZGluYXRlcyc6W1swLDBdLCBbMCwxXV0sICd0eXBlJzonTGluZVN0cmluZyd9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZ2VvanNvbihyLmhhc2hNYXAoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpKSkud2l0aChcInR5cGVcIiwgXCJMaW5lU3RyaW5nXCIpKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIoeyckcmVxbF90eXBlJCc6J0dFT01FVFJZJywgJ2Nvb3JkaW5hdGVzJzpbWzAsMF0sIFswLDFdXSwgJ3R5cGUnOidMaW5lU3RyaW5nJ30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheShyLmFycmF5KDBMLCAwTCksIHIuYXJyYXkoMEwsIDFMKSkpLndpdGgoXCJ0eXBlXCIsIFwiTGluZVN0cmluZ1wiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/geojson.yaml, #6
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0,0], [0,1]], 'type':'LineString'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L))).with("type", "LineString");
                 
                 /* Original: r.geojson({'coordinates':[[0,0], [0,1]], 'type':'LineString'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L))).with("type", "LineString")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiI4IiwiT3JpZ2luYWwiOiJyLmdlb2pzb24oeydjb29yZGluYXRlcyc6W1tbMCwwXSwgWzAsMV0sIFsxLDBdLCBbMCwwXV1dLCAndHlwZSc6J1BvbHlnb24nfSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmdlb2pzb24oci5oYXNoTWFwKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheShyLmFycmF5KHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDFMLCAwTCksIHIuYXJyYXkoMEwsIDBMKSkpKS53aXRoKFwidHlwZVwiLCBcIlBvbHlnb25cIikpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Iih7JyRyZXFsX3R5cGUkJzonR0VPTUVUUlknLCAnY29vcmRpbmF0ZXMnOltbWzAsMF0sIFswLDFdLCBbMSwwXSwgWzAsMF1dXSwgJ3R5cGUnOidQb2x5Z29uJ30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheShyLmFycmF5KHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDFMLCAwTCksIHIuYXJyYXkoMEwsIDBMKSkpKS53aXRoKFwidHlwZVwiLCBcIlBvbHlnb25cIikiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/geojson.yaml, #8
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon");
                 
                 /* Original: r.geojson({'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIxMiIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOltbXSwgMF0sICd0eXBlJzonUG9pbnQnfSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmdlb2pzb24oci5oYXNoTWFwKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheShyLmFycmF5KCksIDBMKSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBBUlJBWS4nLCBbMF0pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkV4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBBUlJBWS5cIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/geojson.yaml, #12
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found ARRAY.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found ARRAY.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[[], 0], 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(), 0L)).with("type", "Point")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIxNCIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOnRydWUsICd0eXBlJzonUG9pbnQnfSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmdlb2pzb24oci5oYXNoTWFwKFwiY29vcmRpbmF0ZXNcIiwgdHJ1ZSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHR5cGUgQVJSQVkgYnV0IGZvdW5kIEJPT0wuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIEFSUkFZIGJ1dCBmb3VuZCBCT09MLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/geojson.yaml, #14
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type ARRAY but found BOOL.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found BOOL.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':true, 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", true).with("type", "Point")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIxNiIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsndHlwZSc6J1BvaW50J30pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5nZW9qc29uKHIuaGFzaE1hcChcInR5cGVcIiwgXCJQb2ludFwiKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsTm9uRXhpc3RlbmNlRXJyb3InLCAnTm8gYXR0cmlidXRlIGBjb29yZGluYXRlc2AgaW4gb2JqZWN0OicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsTm9uRXhpc3RlbmNlRXJyb3JcIiwgXCJObyBhdHRyaWJ1dGUgYGNvb3JkaW5hdGVzYCBpbiBvYmplY3Q6XCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/geojson.yaml, #16
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'No attribute `coordinates` in object:', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "No attribute `coordinates` in object:", r.array(0L));
                 
                 /* Original: r.geojson({'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("type", "Point")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIxOCIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOlswLCAwXX0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5nZW9qc29uKHIuaGFzaE1hcChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoMEwsIDBMKSkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbE5vbkV4aXN0ZW5jZUVycm9yJywgJ05vIGF0dHJpYnV0ZSBgdHlwZWAgaW4gb2JqZWN0OicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsTm9uRXhpc3RlbmNlRXJyb3JcIiwgXCJObyBhdHRyaWJ1dGUgYHR5cGVgIGluIG9iamVjdDpcIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/geojson.yaml, #18
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'No attribute `type` in object:', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "No attribute `type` in object:", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0]}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIyMCIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOlswLCAwXSwgJ3R5cGUnOidmb28nfSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmdlb2pzb24oci5oYXNoTWFwKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgMEwpKS53aXRoKFwidHlwZVwiLCBcImZvb1wiKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ1VucmVjb2duaXplZCBHZW9KU09OIHR5cGUgYGZvb2AuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJVbnJlY29nbml6ZWQgR2VvSlNPTiB0eXBlIGBmb29gLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/geojson.yaml, #20
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Unrecognized GeoJSON type `foo`.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Unrecognized GeoJSON type `foo`.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'foo'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "foo")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIyMiIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOlswLCAwXSwgJ3R5cGUnOidQb2ludCcsICdmb28nOid3cm9uZyd9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZ2VvanNvbihyLmhhc2hNYXAoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KDBMLCAwTCkpLndpdGgoXCJ0eXBlXCIsIFwiUG9pbnRcIikud2l0aChcImZvb1wiLCBcIndyb25nXCIpKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoJ1JlcWxRdWVyeUxvZ2ljRXJyb3InLCAnVW5yZWNvZ25pemVkIGZpZWxkIGBmb29gIGZvdW5kIGluIGdlb21ldHJ5IG9iamVjdC4nLCBbMF0pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIlVucmVjb2duaXplZCBmaWVsZCBgZm9vYCBmb3VuZCBpbiBnZW9tZXRyeSBvYmplY3QuXCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/geojson.yaml, #22
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Unrecognized field `foo` found in geometry object.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Unrecognized field `foo` found in geometry object.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point', 'foo':'wrong'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point").with("foo", "wrong")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIyNiIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOlswLCAwXSwgJ3R5cGUnOidQb2ludCcsICdjcnMnOm51bGx9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZ2VvanNvbihyLmhhc2hNYXAoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KDBMLCAwTCkpLndpdGgoXCJ0eXBlXCIsIFwiUG9pbnRcIikud2l0aChcImNyc1wiLCBudWxsKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6WzAsIDBdLCAndHlwZSc6J1BvaW50JywgJ2Nycyc6bnVsbH0pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgMEwpKS53aXRoKFwidHlwZVwiLCBcIlBvaW50XCIpLndpdGgoXCJjcnNcIiwgbnVsbCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/geojson.yaml, #26
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 0], 'type':'Point', 'crs':null}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point").with("crs", null);
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point', 'crs':null}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point").with("crs", null)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2dlb2pzb24ueWFtbCIsIkxpbmVOdW0iOiIzMCIsIk9yaWdpbmFsIjoici5nZW9qc29uKHsnY29vcmRpbmF0ZXMnOlswLCAwXSwgJ3R5cGUnOidNdWx0aVBvaW50J30pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5nZW9qc29uKHIuaGFzaE1hcChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoMEwsIDBMKSkud2l0aChcInR5cGVcIiwgXCJNdWx0aVBvaW50XCIpKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoJ1JlcWxRdWVyeUxvZ2ljRXJyb3InLCAnR2VvSlNPTiB0eXBlIGBNdWx0aVBvaW50YCBpcyBub3Qgc3VwcG9ydGVkLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiR2VvSlNPTiB0eXBlIGBNdWx0aVBvaW50YCBpcyBub3Qgc3VwcG9ydGVkLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/geojson.yaml, #30
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'GeoJSON type `MultiPoint` is not supported.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "GeoJSON type `MultiPoint` is not supported.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'MultiPoint'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "MultiPoint")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
