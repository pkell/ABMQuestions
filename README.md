Solution contains three projects:  
    1. Parsing - Contains the static classes to carry out the operations on both the Edifact Message and the XML documents requested as part of the challenge.  
    2. Parsing.Tests - Unit tests for the Parsing project. There are tests to prove that the code does what was requested.  
    3. XMLWebService - Contains a WebService with a WebMethod wrapping the XML validation logic in the Parsing project. The method called by the WebMethod is tested in Parsing.Tests.
  
  The web service follows the return codes specified return codes but also returns -3 if the xml is invalid or invalid under the schema.