// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: reports/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SKF.Enlight.API.Reports {
  public static partial class Reports
  {
    static readonly string __ServiceName = "reportsgrpcapi.Reports";

    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Void> __Marshaller_common_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.DeepPingOutput> __Marshaller_reportsgrpcapi_DeepPingOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.DeepPingOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetAssetHealthInput> __Marshaller_reportsgrpcapi_GetAssetHealthInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetAssetHealthInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetAssetHealthOutput> __Marshaller_reportsgrpcapi_GetAssetHealthOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetAssetHealthOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput> __Marshaller_reportsgrpcapi_GetFunctionalLocationHealthInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput> __Marshaller_reportsgrpcapi_GetFunctionalLocationHealthOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetComplianceLogInput> __Marshaller_reportsgrpcapi_GetComplianceLogInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetComplianceLogInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetComplianceLogOutput> __Marshaller_reportsgrpcapi_GetComplianceLogOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetComplianceLogOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetReportsInput> __Marshaller_reportsgrpcapi_GetReportsInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetReportsInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetReportsOutput> __Marshaller_reportsgrpcapi_GetReportsOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetReportsOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetComplianceSummaryInput> __Marshaller_reportsgrpcapi_GetComplianceSummaryInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetComplianceSummaryInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput> __Marshaller_reportsgrpcapi_GetComplianceSummaryOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput.Parser.ParseFrom);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Reports.DeepPingOutput> __Method_DeepPing = new grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Reports.DeepPingOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeepPing",
        __Marshaller_common_Void,
        __Marshaller_reportsgrpcapi_DeepPingOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Reports.GetAssetHealthInput, global::SKF.Enlight.API.Reports.GetAssetHealthOutput> __Method_GetAssetHealth = new grpc::Method<global::SKF.Enlight.API.Reports.GetAssetHealthInput, global::SKF.Enlight.API.Reports.GetAssetHealthOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAssetHealth",
        __Marshaller_reportsgrpcapi_GetAssetHealthInput,
        __Marshaller_reportsgrpcapi_GetAssetHealthOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput, global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput> __Method_GetFunctionalLocationHealth = new grpc::Method<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput, global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFunctionalLocationHealth",
        __Marshaller_reportsgrpcapi_GetFunctionalLocationHealthInput,
        __Marshaller_reportsgrpcapi_GetFunctionalLocationHealthOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Reports.GetComplianceLogInput, global::SKF.Enlight.API.Reports.GetComplianceLogOutput> __Method_GetComplianceLog = new grpc::Method<global::SKF.Enlight.API.Reports.GetComplianceLogInput, global::SKF.Enlight.API.Reports.GetComplianceLogOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetComplianceLog",
        __Marshaller_reportsgrpcapi_GetComplianceLogInput,
        __Marshaller_reportsgrpcapi_GetComplianceLogOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Reports.GetReportsInput, global::SKF.Enlight.API.Reports.GetReportsOutput> __Method_GetReports = new grpc::Method<global::SKF.Enlight.API.Reports.GetReportsInput, global::SKF.Enlight.API.Reports.GetReportsOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReports",
        __Marshaller_reportsgrpcapi_GetReportsInput,
        __Marshaller_reportsgrpcapi_GetReportsOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Reports.GetComplianceSummaryInput, global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput> __Method_GetComplianceSummary = new grpc::Method<global::SKF.Enlight.API.Reports.GetComplianceSummaryInput, global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetComplianceSummary",
        __Marshaller_reportsgrpcapi_GetComplianceSummaryInput,
        __Marshaller_reportsgrpcapi_GetComplianceSummaryOutput);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SKF.Enlight.API.Reports.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Reports</summary>
    [grpc::BindServiceMethod(typeof(Reports), "BindService")]
    public abstract partial class ReportsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.DeepPingOutput> DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.GetAssetHealthOutput> GetAssetHealth(global::SKF.Enlight.API.Reports.GetAssetHealthInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput> GetFunctionalLocationHealth(global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.GetComplianceLogOutput> GetComplianceLog(global::SKF.Enlight.API.Reports.GetComplianceLogInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.GetReportsOutput> GetReports(global::SKF.Enlight.API.Reports.GetReportsInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput> GetComplianceSummary(global::SKF.Enlight.API.Reports.GetComplianceSummaryInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Reports</summary>
    public partial class ReportsClient : grpc::ClientBase<ReportsClient>
    {
      /// <summary>Creates a new client for Reports</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReportsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Reports that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReportsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReportsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReportsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SKF.Enlight.API.Reports.DeepPingOutput DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.DeepPingOutput DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.DeepPingOutput> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.DeepPingOutput> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Reports.GetAssetHealthOutput GetAssetHealth(global::SKF.Enlight.API.Reports.GetAssetHealthInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAssetHealth(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.GetAssetHealthOutput GetAssetHealth(global::SKF.Enlight.API.Reports.GetAssetHealthInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAssetHealth, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetAssetHealthOutput> GetAssetHealthAsync(global::SKF.Enlight.API.Reports.GetAssetHealthInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAssetHealthAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetAssetHealthOutput> GetAssetHealthAsync(global::SKF.Enlight.API.Reports.GetAssetHealthInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAssetHealth, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput GetFunctionalLocationHealth(global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFunctionalLocationHealth(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput GetFunctionalLocationHealth(global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFunctionalLocationHealth, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput> GetFunctionalLocationHealthAsync(global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFunctionalLocationHealthAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput> GetFunctionalLocationHealthAsync(global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFunctionalLocationHealth, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Reports.GetComplianceLogOutput GetComplianceLog(global::SKF.Enlight.API.Reports.GetComplianceLogInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetComplianceLog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.GetComplianceLogOutput GetComplianceLog(global::SKF.Enlight.API.Reports.GetComplianceLogInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetComplianceLog, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetComplianceLogOutput> GetComplianceLogAsync(global::SKF.Enlight.API.Reports.GetComplianceLogInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetComplianceLogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetComplianceLogOutput> GetComplianceLogAsync(global::SKF.Enlight.API.Reports.GetComplianceLogInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetComplianceLog, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Reports.GetReportsOutput GetReports(global::SKF.Enlight.API.Reports.GetReportsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReports(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.GetReportsOutput GetReports(global::SKF.Enlight.API.Reports.GetReportsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReports, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetReportsOutput> GetReportsAsync(global::SKF.Enlight.API.Reports.GetReportsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReportsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetReportsOutput> GetReportsAsync(global::SKF.Enlight.API.Reports.GetReportsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReports, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput GetComplianceSummary(global::SKF.Enlight.API.Reports.GetComplianceSummaryInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetComplianceSummary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput GetComplianceSummary(global::SKF.Enlight.API.Reports.GetComplianceSummaryInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetComplianceSummary, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput> GetComplianceSummaryAsync(global::SKF.Enlight.API.Reports.GetComplianceSummaryInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetComplianceSummaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput> GetComplianceSummaryAsync(global::SKF.Enlight.API.Reports.GetComplianceSummaryInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetComplianceSummary, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReportsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReportsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReportsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeepPing, serviceImpl.DeepPing)
          .AddMethod(__Method_GetAssetHealth, serviceImpl.GetAssetHealth)
          .AddMethod(__Method_GetFunctionalLocationHealth, serviceImpl.GetFunctionalLocationHealth)
          .AddMethod(__Method_GetComplianceLog, serviceImpl.GetComplianceLog)
          .AddMethod(__Method_GetReports, serviceImpl.GetReports)
          .AddMethod(__Method_GetComplianceSummary, serviceImpl.GetComplianceSummary).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReportsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeepPing, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Reports.DeepPingOutput>(serviceImpl.DeepPing));
      serviceBinder.AddMethod(__Method_GetAssetHealth, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Reports.GetAssetHealthInput, global::SKF.Enlight.API.Reports.GetAssetHealthOutput>(serviceImpl.GetAssetHealth));
      serviceBinder.AddMethod(__Method_GetFunctionalLocationHealth, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthInput, global::SKF.Enlight.API.Reports.GetFunctionalLocationHealthOutput>(serviceImpl.GetFunctionalLocationHealth));
      serviceBinder.AddMethod(__Method_GetComplianceLog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Reports.GetComplianceLogInput, global::SKF.Enlight.API.Reports.GetComplianceLogOutput>(serviceImpl.GetComplianceLog));
      serviceBinder.AddMethod(__Method_GetReports, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Reports.GetReportsInput, global::SKF.Enlight.API.Reports.GetReportsOutput>(serviceImpl.GetReports));
      serviceBinder.AddMethod(__Method_GetComplianceSummary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Reports.GetComplianceSummaryInput, global::SKF.Enlight.API.Reports.GetComplianceSummaryOutput>(serviceImpl.GetComplianceSummary));
    }

  }
}
#endregion
