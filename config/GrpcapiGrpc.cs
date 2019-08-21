// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: config/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SKF.Enlight.API.Config {
  public static partial class ResourceConfig
  {
    static readonly string __ServiceName = "grpcapi.ResourceConfig";

    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.SpecificationRequest> __Marshaller_grpcapi_SpecificationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.SpecificationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.SpecificationResponse> __Marshaller_grpcapi_SpecificationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.SpecificationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.ConfigRequest> __Marshaller_grpcapi_ConfigRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.ConfigRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.ConfigsResponse> __Marshaller_grpcapi_ConfigsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.ConfigsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.LatestConfigRequest> __Marshaller_grpcapi_LatestConfigRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.LatestConfigRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Void> __Marshaller_common_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.SetConfigRequest> __Marshaller_grpcapi_SetConfigRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.SetConfigRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Config.ConfigResponse> __Marshaller_grpcapi_ConfigResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Config.ConfigResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::SKF.Enlight.API.Config.SpecificationRequest, global::SKF.Enlight.API.Config.SpecificationResponse> __Method_GetSpecification = new grpc::Method<global::SKF.Enlight.API.Config.SpecificationRequest, global::SKF.Enlight.API.Config.SpecificationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSpecification",
        __Marshaller_grpcapi_SpecificationRequest,
        __Marshaller_grpcapi_SpecificationResponse);

    static readonly grpc::Method<global::SKF.Enlight.API.Config.ConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse> __Method_GetConfig = new grpc::Method<global::SKF.Enlight.API.Config.ConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetConfig",
        __Marshaller_grpcapi_ConfigRequest,
        __Marshaller_grpcapi_ConfigsResponse);

    static readonly grpc::Method<global::SKF.Enlight.API.Config.LatestConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse> __Method_GetLatestConfigByTargetID = new grpc::Method<global::SKF.Enlight.API.Config.LatestConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLatestConfigByTargetID",
        __Marshaller_grpcapi_LatestConfigRequest,
        __Marshaller_grpcapi_ConfigsResponse);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Config.ConfigsResponse> __Method_GetAllLatestConfigs = new grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Config.ConfigsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllLatestConfigs",
        __Marshaller_common_Void,
        __Marshaller_grpcapi_ConfigsResponse);

    static readonly grpc::Method<global::SKF.Enlight.API.Config.SetConfigRequest, global::SKF.Enlight.API.Config.ConfigResponse> __Method_SetConfigByTargetIDs = new grpc::Method<global::SKF.Enlight.API.Config.SetConfigRequest, global::SKF.Enlight.API.Config.ConfigResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetConfigByTargetIDs",
        __Marshaller_grpcapi_SetConfigRequest,
        __Marshaller_grpcapi_ConfigResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SKF.Enlight.API.Config.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ResourceConfig</summary>
    [grpc::BindServiceMethod(typeof(ResourceConfig), "BindService")]
    public abstract partial class ResourceConfigBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Config.SpecificationResponse> GetSpecification(global::SKF.Enlight.API.Config.SpecificationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Config.ConfigsResponse> GetConfig(global::SKF.Enlight.API.Config.ConfigRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Config.ConfigsResponse> GetLatestConfigByTargetID(global::SKF.Enlight.API.Config.LatestConfigRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Config.ConfigsResponse> GetAllLatestConfigs(global::SKF.Enlight.API.Common.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Config.ConfigResponse> SetConfigByTargetIDs(global::SKF.Enlight.API.Config.SetConfigRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ResourceConfig</summary>
    public partial class ResourceConfigClient : grpc::ClientBase<ResourceConfigClient>
    {
      /// <summary>Creates a new client for ResourceConfig</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ResourceConfigClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ResourceConfig that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ResourceConfigClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ResourceConfigClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ResourceConfigClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SKF.Enlight.API.Config.SpecificationResponse GetSpecification(global::SKF.Enlight.API.Config.SpecificationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSpecification(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Config.SpecificationResponse GetSpecification(global::SKF.Enlight.API.Config.SpecificationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSpecification, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.SpecificationResponse> GetSpecificationAsync(global::SKF.Enlight.API.Config.SpecificationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSpecificationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.SpecificationResponse> GetSpecificationAsync(global::SKF.Enlight.API.Config.SpecificationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSpecification, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetConfig(global::SKF.Enlight.API.Config.ConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetConfig(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetConfig(global::SKF.Enlight.API.Config.ConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetConfig, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetConfigAsync(global::SKF.Enlight.API.Config.ConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetConfigAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetConfigAsync(global::SKF.Enlight.API.Config.ConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetConfig, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetLatestConfigByTargetID(global::SKF.Enlight.API.Config.LatestConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLatestConfigByTargetID(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetLatestConfigByTargetID(global::SKF.Enlight.API.Config.LatestConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLatestConfigByTargetID, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetLatestConfigByTargetIDAsync(global::SKF.Enlight.API.Config.LatestConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLatestConfigByTargetIDAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetLatestConfigByTargetIDAsync(global::SKF.Enlight.API.Config.LatestConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLatestConfigByTargetID, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetAllLatestConfigs(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllLatestConfigs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Config.ConfigsResponse GetAllLatestConfigs(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllLatestConfigs, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetAllLatestConfigsAsync(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllLatestConfigsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigsResponse> GetAllLatestConfigsAsync(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllLatestConfigs, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Config.ConfigResponse SetConfigByTargetIDs(global::SKF.Enlight.API.Config.SetConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetConfigByTargetIDs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Config.ConfigResponse SetConfigByTargetIDs(global::SKF.Enlight.API.Config.SetConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetConfigByTargetIDs, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigResponse> SetConfigByTargetIDsAsync(global::SKF.Enlight.API.Config.SetConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetConfigByTargetIDsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Config.ConfigResponse> SetConfigByTargetIDsAsync(global::SKF.Enlight.API.Config.SetConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetConfigByTargetIDs, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ResourceConfigClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ResourceConfigClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ResourceConfigBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSpecification, serviceImpl.GetSpecification)
          .AddMethod(__Method_GetConfig, serviceImpl.GetConfig)
          .AddMethod(__Method_GetLatestConfigByTargetID, serviceImpl.GetLatestConfigByTargetID)
          .AddMethod(__Method_GetAllLatestConfigs, serviceImpl.GetAllLatestConfigs)
          .AddMethod(__Method_SetConfigByTargetIDs, serviceImpl.SetConfigByTargetIDs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ResourceConfigBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSpecification, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Config.SpecificationRequest, global::SKF.Enlight.API.Config.SpecificationResponse>(serviceImpl.GetSpecification));
      serviceBinder.AddMethod(__Method_GetConfig, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Config.ConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse>(serviceImpl.GetConfig));
      serviceBinder.AddMethod(__Method_GetLatestConfigByTargetID, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Config.LatestConfigRequest, global::SKF.Enlight.API.Config.ConfigsResponse>(serviceImpl.GetLatestConfigByTargetID));
      serviceBinder.AddMethod(__Method_GetAllLatestConfigs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Config.ConfigsResponse>(serviceImpl.GetAllLatestConfigs));
      serviceBinder.AddMethod(__Method_SetConfigByTargetIDs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Config.SetConfigRequest, global::SKF.Enlight.API.Config.ConfigResponse>(serviceImpl.SetConfigByTargetIDs));
    }

  }
}
#endregion
