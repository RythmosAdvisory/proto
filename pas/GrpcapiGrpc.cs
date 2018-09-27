// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: pas/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SKF.Enlight.API.PAS {
  public static partial class PointAlarmStatus
  {
    static readonly string __ServiceName = "pasapi.PointAlarmStatus";

    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Void> __Marshaller_common_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.DeepPingOutput> __Marshaller_pasapi_DeepPingOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.DeepPingOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput> __Marshaller_pasapi_SetPointAlarmThresholdInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput> __Marshaller_pasapi_SetPointAlarmThresholdOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput> __Marshaller_pasapi_GetPointAlarmThresholdInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput> __Marshaller_pasapi_GetPointAlarmThresholdOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput> __Marshaller_pasapi_SetPointAlarmStatusInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput> __Marshaller_pasapi_SetPointAlarmStatusOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput> __Marshaller_pasapi_GetPointAlarmStatusInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput> __Marshaller_pasapi_GetPointAlarmStatusOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput> __Marshaller_pasapi_GetPointAlarmStatusStreamInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput> __Marshaller_pasapi_GetPointAlarmStatusStreamOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput.Parser.ParseFrom);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.PAS.DeepPingOutput> __Method_DeepPing = new grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.PAS.DeepPingOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeepPing",
        __Marshaller_common_Void,
        __Marshaller_pasapi_DeepPingOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput, global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput> __Method_SetPointAlarmThreshold = new grpc::Method<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput, global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetPointAlarmThreshold",
        __Marshaller_pasapi_SetPointAlarmThresholdInput,
        __Marshaller_pasapi_SetPointAlarmThresholdOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput, global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput> __Method_GetPointAlarmThreshold = new grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput, global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPointAlarmThreshold",
        __Marshaller_pasapi_GetPointAlarmThresholdInput,
        __Marshaller_pasapi_GetPointAlarmThresholdOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput, global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput> __Method_SetPointAlarmStatus = new grpc::Method<global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput, global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetPointAlarmStatus",
        __Marshaller_pasapi_SetPointAlarmStatusInput,
        __Marshaller_pasapi_SetPointAlarmStatusOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput, global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput> __Method_GetPointAlarmStatus = new grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput, global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPointAlarmStatus",
        __Marshaller_pasapi_GetPointAlarmStatusInput,
        __Marshaller_pasapi_GetPointAlarmStatusOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput, global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput> __Method_GetPointAlarmStatusStream = new grpc::Method<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput, global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetPointAlarmStatusStream",
        __Marshaller_pasapi_GetPointAlarmStatusStreamInput,
        __Marshaller_pasapi_GetPointAlarmStatusStreamOutput);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SKF.Enlight.API.PAS.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PointAlarmStatus</summary>
    public abstract partial class PointAlarmStatusBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.PAS.DeepPingOutput> DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput> SetPointAlarmThreshold(global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput> GetPointAlarmThreshold(global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput> SetPointAlarmStatus(global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput> GetPointAlarmStatus(global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetPointAlarmStatusStream(global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput request, grpc::IServerStreamWriter<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PointAlarmStatus</summary>
    public partial class PointAlarmStatusClient : grpc::ClientBase<PointAlarmStatusClient>
    {
      /// <summary>Creates a new client for PointAlarmStatus</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PointAlarmStatusClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PointAlarmStatus that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PointAlarmStatusClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PointAlarmStatusClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PointAlarmStatusClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SKF.Enlight.API.PAS.DeepPingOutput DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.PAS.DeepPingOutput DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.DeepPingOutput> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.DeepPingOutput> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput SetPointAlarmThreshold(global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPointAlarmThreshold(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput SetPointAlarmThreshold(global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetPointAlarmThreshold, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput> SetPointAlarmThresholdAsync(global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPointAlarmThresholdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.SetPointAlarmThresholdOutput> SetPointAlarmThresholdAsync(global::SKF.Enlight.API.PAS.SetPointAlarmThresholdInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetPointAlarmThreshold, null, options, request);
      }
      public virtual global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput GetPointAlarmThreshold(global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPointAlarmThreshold(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput GetPointAlarmThreshold(global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPointAlarmThreshold, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput> GetPointAlarmThresholdAsync(global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPointAlarmThresholdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.GetPointAlarmThresholdOutput> GetPointAlarmThresholdAsync(global::SKF.Enlight.API.PAS.GetPointAlarmThresholdInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPointAlarmThreshold, null, options, request);
      }
      public virtual global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput SetPointAlarmStatus(global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPointAlarmStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput SetPointAlarmStatus(global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetPointAlarmStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput> SetPointAlarmStatusAsync(global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPointAlarmStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.SetPointAlarmStatusOutput> SetPointAlarmStatusAsync(global::SKF.Enlight.API.PAS.SetPointAlarmStatusInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetPointAlarmStatus, null, options, request);
      }
      public virtual global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput GetPointAlarmStatus(global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPointAlarmStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput GetPointAlarmStatus(global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPointAlarmStatus, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput> GetPointAlarmStatusAsync(global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPointAlarmStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.PAS.GetPointAlarmStatusOutput> GetPointAlarmStatusAsync(global::SKF.Enlight.API.PAS.GetPointAlarmStatusInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPointAlarmStatus, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput> GetPointAlarmStatusStream(global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPointAlarmStatusStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamOutput> GetPointAlarmStatusStream(global::SKF.Enlight.API.PAS.GetPointAlarmStatusStreamInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetPointAlarmStatusStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PointAlarmStatusClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PointAlarmStatusClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PointAlarmStatusBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeepPing, serviceImpl.DeepPing)
          .AddMethod(__Method_SetPointAlarmThreshold, serviceImpl.SetPointAlarmThreshold)
          .AddMethod(__Method_GetPointAlarmThreshold, serviceImpl.GetPointAlarmThreshold)
          .AddMethod(__Method_SetPointAlarmStatus, serviceImpl.SetPointAlarmStatus)
          .AddMethod(__Method_GetPointAlarmStatus, serviceImpl.GetPointAlarmStatus)
          .AddMethod(__Method_GetPointAlarmStatusStream, serviceImpl.GetPointAlarmStatusStream).Build();
    }

  }
}
#endregion
