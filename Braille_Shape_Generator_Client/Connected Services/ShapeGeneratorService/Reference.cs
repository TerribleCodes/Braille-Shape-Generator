﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Braille_Shape_Generator_Client.ShapeGeneratorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShapeGeneratorService.Shape_Generator_ServiceSoap")]
    public interface Shape_Generator_ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circle", ReplyAction="*")]
        double Circle(double radius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circle", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CircleAsync(double radius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Triangle", ReplyAction="*")]
        double Triangle(double height, double width);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Triangle", ReplyAction="*")]
        System.Threading.Tasks.Task<double> TriangleAsync(double height, double width);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rectangle", ReplyAction="*")]
        double Rectangle(double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rectangle", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RectangleAsync(double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Square", ReplyAction="*")]
        double Square(double length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Square", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SquareAsync(double length);
        
        // CODEGEN: Generating message contract since element name number from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBrailleDots", ReplyAction="*")]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse GetBrailleDots(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBrailleDots", ReplyAction="*")]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse> GetBrailleDotsAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest request);
        
        // CODEGEN: Generating message contract since element name GetNumbersResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetNumbers", ReplyAction="*")]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse GetNumbers(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse> GetNumbersAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest request);
        
        // CODEGEN: Generating message contract since element name letter from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBrailleDotsLetters", ReplyAction="*")]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse GetBrailleDotsLetters(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBrailleDotsLetters", ReplyAction="*")]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse> GetBrailleDotsLettersAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBrailleDotsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBrailleDots", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequestBody Body;
        
        public GetBrailleDotsRequest() {
        }
        
        public GetBrailleDotsRequest(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBrailleDotsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string number;
        
        public GetBrailleDotsRequestBody() {
        }
        
        public GetBrailleDotsRequestBody(string number) {
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBrailleDotsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBrailleDotsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponseBody Body;
        
        public GetBrailleDotsResponse() {
        }
        
        public GetBrailleDotsResponse(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBrailleDotsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetBrailleDotsResult;
        
        public GetBrailleDotsResponseBody() {
        }
        
        public GetBrailleDotsResponseBody(int GetBrailleDotsResult) {
            this.GetBrailleDotsResult = GetBrailleDotsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNumbersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNumbers", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequestBody Body;
        
        public GetNumbersRequest() {
        }
        
        public GetNumbersRequest(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetNumbersRequestBody {
        
        public GetNumbersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNumbersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNumbersResponse", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponseBody Body;
        
        public GetNumbersResponse() {
        }
        
        public GetNumbersResponse(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetNumbersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.ArrayOfString GetNumbersResult;
        
        public GetNumbersResponseBody() {
        }
        
        public GetNumbersResponseBody(Braille_Shape_Generator_Client.ShapeGeneratorService.ArrayOfString GetNumbersResult) {
            this.GetNumbersResult = GetNumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBrailleDotsLettersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBrailleDotsLetters", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequestBody Body;
        
        public GetBrailleDotsLettersRequest() {
        }
        
        public GetBrailleDotsLettersRequest(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBrailleDotsLettersRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string letter;
        
        public GetBrailleDotsLettersRequestBody() {
        }
        
        public GetBrailleDotsLettersRequestBody(string letter) {
            this.letter = letter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBrailleDotsLettersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBrailleDotsLettersResponse", Namespace="http://tempuri.org/", Order=0)]
        public Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponseBody Body;
        
        public GetBrailleDotsLettersResponse() {
        }
        
        public GetBrailleDotsLettersResponse(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBrailleDotsLettersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetBrailleDotsLettersResult;
        
        public GetBrailleDotsLettersResponseBody() {
        }
        
        public GetBrailleDotsLettersResponseBody(int GetBrailleDotsLettersResult) {
            this.GetBrailleDotsLettersResult = GetBrailleDotsLettersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Shape_Generator_ServiceSoapChannel : Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Shape_Generator_ServiceSoapClient : System.ServiceModel.ClientBase<Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap>, Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap {
        
        public Shape_Generator_ServiceSoapClient() {
        }
        
        public Shape_Generator_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Shape_Generator_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Shape_Generator_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Shape_Generator_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Circle(double radius) {
            return base.Channel.Circle(radius);
        }
        
        public System.Threading.Tasks.Task<double> CircleAsync(double radius) {
            return base.Channel.CircleAsync(radius);
        }
        
        public double Triangle(double height, double width) {
            return base.Channel.Triangle(height, width);
        }
        
        public System.Threading.Tasks.Task<double> TriangleAsync(double height, double width) {
            return base.Channel.TriangleAsync(height, width);
        }
        
        public double Rectangle(double width, double height) {
            return base.Channel.Rectangle(width, height);
        }
        
        public System.Threading.Tasks.Task<double> RectangleAsync(double width, double height) {
            return base.Channel.RectangleAsync(width, height);
        }
        
        public double Square(double length) {
            return base.Channel.Square(length);
        }
        
        public System.Threading.Tasks.Task<double> SquareAsync(double length) {
            return base.Channel.SquareAsync(length);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetBrailleDots(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest request) {
            return base.Channel.GetBrailleDots(request);
        }
        
        public int GetBrailleDots(string number) {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequestBody();
            inValue.Body.number = number;
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse retVal = ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetBrailleDots(inValue);
            return retVal.Body.GetBrailleDotsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse> Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetBrailleDotsAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest request) {
            return base.Channel.GetBrailleDotsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsResponse> GetBrailleDotsAsync(string number) {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsRequestBody();
            inValue.Body.number = number;
            return ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetBrailleDotsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetNumbers(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest request) {
            return base.Channel.GetNumbers(request);
        }
        
        public Braille_Shape_Generator_Client.ShapeGeneratorService.ArrayOfString GetNumbers() {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequestBody();
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse retVal = ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetNumbers(inValue);
            return retVal.Body.GetNumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse> Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetNumbersAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest request) {
            return base.Channel.GetNumbersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersResponse> GetNumbersAsync() {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetNumbersRequestBody();
            return ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetNumbersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetBrailleDotsLetters(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest request) {
            return base.Channel.GetBrailleDotsLetters(request);
        }
        
        public int GetBrailleDotsLetters(string letter) {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequestBody();
            inValue.Body.letter = letter;
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse retVal = ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetBrailleDotsLetters(inValue);
            return retVal.Body.GetBrailleDotsLettersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse> Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap.GetBrailleDotsLettersAsync(Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest request) {
            return base.Channel.GetBrailleDotsLettersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersResponse> GetBrailleDotsLettersAsync(string letter) {
            Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest inValue = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequest();
            inValue.Body = new Braille_Shape_Generator_Client.ShapeGeneratorService.GetBrailleDotsLettersRequestBody();
            inValue.Body.letter = letter;
            return ((Braille_Shape_Generator_Client.ShapeGeneratorService.Shape_Generator_ServiceSoap)(this)).GetBrailleDotsLettersAsync(inValue);
        }
    }
}
