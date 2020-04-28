// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/postcomment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC_Service {
  public static partial class PostComment
  {
    static readonly string __ServiceName = "PostCommentServer.PostComment";

    static readonly grpc::Marshaller<global::gRPC_Service.PostItem> __Marshaller_PostCommentServer_PostItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.PostItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.BooleanResponse> __Marshaller_PostCommentServer_BooleanResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.BooleanResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.IdItem> __Marshaller_PostCommentServer_IdItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.IdItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.IntegerResponse> __Marshaller_PostCommentServer_IntegerResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.IntegerResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.EmptyRequest> __Marshaller_PostCommentServer_EmptyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.EmptyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.AllPostItems> __Marshaller_PostCommentServer_AllPostItems = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.AllPostItems.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Service.CommentItem> __Marshaller_PostCommentServer_CommentItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Service.CommentItem.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPC_Service.PostItem, global::gRPC_Service.BooleanResponse> __Method_AddPost = new grpc::Method<global::gRPC_Service.PostItem, global::gRPC_Service.BooleanResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PostCommentServer_PostItem,
        __Marshaller_PostCommentServer_BooleanResponse);

    static readonly grpc::Method<global::gRPC_Service.PostItem, global::gRPC_Service.PostItem> __Method_UpdatePost = new grpc::Method<global::gRPC_Service.PostItem, global::gRPC_Service.PostItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PostCommentServer_PostItem,
        __Marshaller_PostCommentServer_PostItem);

    static readonly grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.IntegerResponse> __Method_DeletePost = new grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.IntegerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_PostCommentServer_IdItem,
        __Marshaller_PostCommentServer_IntegerResponse);

    static readonly grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.PostItem> __Method_GetPostById = new grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.PostItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_PostCommentServer_IdItem,
        __Marshaller_PostCommentServer_PostItem);

    static readonly grpc::Method<global::gRPC_Service.EmptyRequest, global::gRPC_Service.AllPostItems> __Method_GetAllPosts = new grpc::Method<global::gRPC_Service.EmptyRequest, global::gRPC_Service.AllPostItems>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_PostCommentServer_EmptyRequest,
        __Marshaller_PostCommentServer_AllPostItems);

    static readonly grpc::Method<global::gRPC_Service.CommentItem, global::gRPC_Service.BooleanResponse> __Method_AddComment = new grpc::Method<global::gRPC_Service.CommentItem, global::gRPC_Service.BooleanResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_PostCommentServer_CommentItem,
        __Marshaller_PostCommentServer_BooleanResponse);

    static readonly grpc::Method<global::gRPC_Service.CommentItem, global::gRPC_Service.CommentItem> __Method_UpdateComment = new grpc::Method<global::gRPC_Service.CommentItem, global::gRPC_Service.CommentItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_PostCommentServer_CommentItem,
        __Marshaller_PostCommentServer_CommentItem);

    static readonly grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.CommentItem> __Method_GetCommentById = new grpc::Method<global::gRPC_Service.IdItem, global::gRPC_Service.CommentItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_PostCommentServer_IdItem,
        __Marshaller_PostCommentServer_CommentItem);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC_Service.PostcommentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PostComment</summary>
    [grpc::BindServiceMethod(typeof(PostComment), "BindService")]
    public abstract partial class PostCommentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.BooleanResponse> AddPost(global::gRPC_Service.PostItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.PostItem> UpdatePost(global::gRPC_Service.PostItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.IntegerResponse> DeletePost(global::gRPC_Service.IdItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.PostItem> GetPostById(global::gRPC_Service.IdItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.AllPostItems> GetAllPosts(global::gRPC_Service.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.BooleanResponse> AddComment(global::gRPC_Service.CommentItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.CommentItem> UpdateComment(global::gRPC_Service.CommentItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Service.CommentItem> GetCommentById(global::gRPC_Service.IdItem request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostCommentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById)
          .AddMethod(__Method_GetAllPosts, serviceImpl.GetAllPosts)
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment)
          .AddMethod(__Method_GetCommentById, serviceImpl.GetCommentById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostCommentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.PostItem, global::gRPC_Service.BooleanResponse>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.PostItem, global::gRPC_Service.PostItem>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.IdItem, global::gRPC_Service.IntegerResponse>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.IdItem, global::gRPC_Service.PostItem>(serviceImpl.GetPostById));
      serviceBinder.AddMethod(__Method_GetAllPosts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.EmptyRequest, global::gRPC_Service.AllPostItems>(serviceImpl.GetAllPosts));
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.CommentItem, global::gRPC_Service.BooleanResponse>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.CommentItem, global::gRPC_Service.CommentItem>(serviceImpl.UpdateComment));
      serviceBinder.AddMethod(__Method_GetCommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Service.IdItem, global::gRPC_Service.CommentItem>(serviceImpl.GetCommentById));
    }

  }
}
#endregion
