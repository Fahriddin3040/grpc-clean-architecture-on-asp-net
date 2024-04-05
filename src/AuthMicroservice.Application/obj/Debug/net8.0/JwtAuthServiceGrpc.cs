// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: jwt_auth_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuthMicroservice.Protos {
  public static partial class JwtAuthProtoService
  {
    static readonly string __ServiceName = "authmicroservice.JwtAuthProtoService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthMicroservice.Protos.RegisterRequest> __Marshaller_authmicroservice_RegisterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthMicroservice.Protos.RegisterRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthMicroservice.Protos.SuccessJwtLoginResponse> __Marshaller_authmicroservice_SuccessJwtLoginResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthMicroservice.Protos.SuccessJwtLoginResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthMicroservice.Protos.LoginRequest> __Marshaller_authmicroservice_LoginRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthMicroservice.Protos.LoginRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthMicroservice.Protos.ValidateTokenRequest> __Marshaller_authmicroservice_ValidateTokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthMicroservice.Protos.ValidateTokenRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthMicroservice.Protos.ValidateTokenResponse> __Marshaller_authmicroservice_ValidateTokenResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthMicroservice.Protos.ValidateTokenResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthMicroservice.Protos.RegisterRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse> __Method_Register = new grpc::Method<global::AuthMicroservice.Protos.RegisterRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Register",
        __Marshaller_authmicroservice_RegisterRequest,
        __Marshaller_authmicroservice_SuccessJwtLoginResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthMicroservice.Protos.LoginRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse> __Method_Login = new grpc::Method<global::AuthMicroservice.Protos.LoginRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_authmicroservice_LoginRequest,
        __Marshaller_authmicroservice_SuccessJwtLoginResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthMicroservice.Protos.ValidateTokenRequest, global::AuthMicroservice.Protos.ValidateTokenResponse> __Method_IsValidToken = new grpc::Method<global::AuthMicroservice.Protos.ValidateTokenRequest, global::AuthMicroservice.Protos.ValidateTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsValidToken",
        __Marshaller_authmicroservice_ValidateTokenRequest,
        __Marshaller_authmicroservice_ValidateTokenResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuthMicroservice.Protos.JwtAuthServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of JwtAuthProtoService</summary>
    [grpc::BindServiceMethod(typeof(JwtAuthProtoService), "BindService")]
    public abstract partial class JwtAuthProtoServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthMicroservice.Protos.SuccessJwtLoginResponse> Register(global::AuthMicroservice.Protos.RegisterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthMicroservice.Protos.SuccessJwtLoginResponse> Login(global::AuthMicroservice.Protos.LoginRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthMicroservice.Protos.ValidateTokenResponse> IsValidToken(global::AuthMicroservice.Protos.ValidateTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(JwtAuthProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Register, serviceImpl.Register)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_IsValidToken, serviceImpl.IsValidToken).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, JwtAuthProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Register, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthMicroservice.Protos.RegisterRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse>(serviceImpl.Register));
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthMicroservice.Protos.LoginRequest, global::AuthMicroservice.Protos.SuccessJwtLoginResponse>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_IsValidToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthMicroservice.Protos.ValidateTokenRequest, global::AuthMicroservice.Protos.ValidateTokenResponse>(serviceImpl.IsValidToken));
    }

  }
}
#endregion
