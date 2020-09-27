// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace mdg.engine.proto
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Trace : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(4, Name = @"start_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? StartTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"end_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? EndTime { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"duration_ns")]
        public ulong DurationNs { get; set; }

        [global::ProtoBuf.ProtoMember(14, Name = @"root")]
        public Node Root { get; set; }

        [global::ProtoBuf.ProtoMember(19, Name = @"signature")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signature { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6)]
        public Details details { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"client_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"client_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"client_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientAddress { get; set; } = "";

        [global::ProtoBuf.ProtoMember(23, Name = @"client_reference_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientReferenceId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10)]
        public Http http { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        public CachePolicy cache_policy { get; set; }

        [global::ProtoBuf.ProtoMember(26, Name = @"query_plan")]
        public QueryPlanNode QueryPlan { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"full_query_cache_hit")]
        public bool FullQueryCacheHit { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"persisted_query_hit")]
        public bool PersistedQueryHit { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"persisted_query_register")]
        public bool PersistedQueryRegister { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"registered_operation")]
        public bool RegisteredOperation { get; set; }

        [global::ProtoBuf.ProtoMember(25, Name = @"forbidden_operation")]
        public bool ForbiddenOperation { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"legacy_signature_needs_resigning")]
        [global::System.ComponentModel.DefaultValue("")]
        public string LegacySignatureNeedsResigning { get; set; } = "";

        [global::ProtoBuf.ProtoContract()]
        public partial class CachePolicy : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public Scope scope { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"max_age_ns")]
            public long MaxAgeNs { get; set; }

            [global::ProtoBuf.ProtoContract()]
            public enum Scope
            {
                [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
                Unknown = 0,
                [global::ProtoBuf.ProtoEnum(Name = @"PUBLIC")]
                Public = 1,
                [global::ProtoBuf.ProtoEnum(Name = @"PRIVATE")]
                Private = 2,
            }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Details : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(4, Name = @"variables_json")]
            [global::ProtoBuf.ProtoMap]
            public global::System.Collections.Generic.Dictionary<string, string> VariablesJsons { get; } = new global::System.Collections.Generic.Dictionary<string, string>();

            [global::ProtoBuf.ProtoMember(1, Name = @"deprecated_variables")]
            [global::ProtoBuf.ProtoMap]
            public global::System.Collections.Generic.Dictionary<string, byte[]> DeprecatedVariables { get; } = new global::System.Collections.Generic.Dictionary<string, byte[]>();

            [global::ProtoBuf.ProtoMember(3, Name = @"operation_name")]
            [global::System.ComponentModel.DefaultValue("")]
            public string OperationName { get; set; } = "";

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Error : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"message")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Message { get; set; } = "";

            [global::ProtoBuf.ProtoMember(2, Name = @"location")]
            public global::System.Collections.Generic.List<Trace.Location> Locations { get; } = new global::System.Collections.Generic.List<Trace.Location>();

            [global::ProtoBuf.ProtoMember(3, Name = @"time_ns")]
            public ulong TimeNs { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"json")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Json { get; set; } = "";

        }

        [global::ProtoBuf.ProtoContract(Name = @"HTTP")]
        public partial class Http : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public Method method { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"host")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Host { get; set; } = "";

            [global::ProtoBuf.ProtoMember(3, Name = @"path")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Path { get; set; } = "";

            [global::ProtoBuf.ProtoMember(4, Name = @"request_headers")]
            [global::ProtoBuf.ProtoMap]
            public global::System.Collections.Generic.Dictionary<string, Trace.Http.Values> RequestHeaders { get; } = new global::System.Collections.Generic.Dictionary<string, Trace.Http.Values>();

            [global::ProtoBuf.ProtoMember(5, Name = @"response_headers")]
            [global::ProtoBuf.ProtoMap]
            public global::System.Collections.Generic.Dictionary<string, Trace.Http.Values> ResponseHeaders { get; } = new global::System.Collections.Generic.Dictionary<string, Trace.Http.Values>();

            [global::ProtoBuf.ProtoMember(6, Name = @"status_code")]
            public uint StatusCode { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"secure")]
            public bool Secure { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"protocol")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Protocol { get; set; } = "";

            [global::ProtoBuf.ProtoContract()]
            public partial class Values : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1)]
                public global::System.Collections.Generic.List<string> value { get; } = new global::System.Collections.Generic.List<string>();

            }

            [global::ProtoBuf.ProtoContract()]
            public enum Method
            {
                [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
                Unknown = 0,
                [global::ProtoBuf.ProtoEnum(Name = @"OPTIONS")]
                Options = 1,
                [global::ProtoBuf.ProtoEnum(Name = @"GET")]
                Get = 2,
                [global::ProtoBuf.ProtoEnum(Name = @"HEAD")]
                Head = 3,
                [global::ProtoBuf.ProtoEnum(Name = @"POST")]
                Post = 4,
                [global::ProtoBuf.ProtoEnum(Name = @"PUT")]
                Put = 5,
                [global::ProtoBuf.ProtoEnum(Name = @"DELETE")]
                Delete = 6,
                [global::ProtoBuf.ProtoEnum(Name = @"TRACE")]
                Trace = 7,
                [global::ProtoBuf.ProtoEnum(Name = @"CONNECT")]
                Connect = 8,
                [global::ProtoBuf.ProtoEnum(Name = @"PATCH")]
                Patch = 9,
            }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Location : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"line")]
            public uint Line { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"column")]
            public uint Column { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Node : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"response_name")]
            [global::System.ComponentModel.DefaultValue("")]
            public string ResponseName
            {
                get => __pbn__id.Is(1) ? ((string)__pbn__id.Object) : "";
                set => __pbn__id = new global::ProtoBuf.DiscriminatedUnion32Object(1, value);
            }
            public bool ShouldSerializeResponseName() => __pbn__id.Is(1);
            public void ResetResponseName() => global::ProtoBuf.DiscriminatedUnion32Object.Reset(ref __pbn__id, 1);

            private global::ProtoBuf.DiscriminatedUnion32Object __pbn__id;

            [global::ProtoBuf.ProtoMember(2, Name = @"index")]
            public uint Index
            {
                get => __pbn__id.Is(2) ? __pbn__id.UInt32 : default;
                set => __pbn__id = new global::ProtoBuf.DiscriminatedUnion32Object(2, value);
            }
            public bool ShouldSerializeIndex() => __pbn__id.Is(2);
            public void ResetIndex() => global::ProtoBuf.DiscriminatedUnion32Object.Reset(ref __pbn__id, 2);

            [global::ProtoBuf.ProtoMember(14, Name = @"original_field_name")]
            [global::System.ComponentModel.DefaultValue("")]
            public string OriginalFieldName { get; set; } = "";

            [global::ProtoBuf.ProtoMember(3, Name = @"type")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Type { get; set; } = "";

            [global::ProtoBuf.ProtoMember(13, Name = @"parent_type")]
            [global::System.ComponentModel.DefaultValue("")]
            public string ParentType { get; set; } = "";

            [global::ProtoBuf.ProtoMember(5, Name = @"cache_policy")]
            public Trace.CachePolicy CachePolicy { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"start_time")]
            public ulong StartTime { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"end_time")]
            public ulong EndTime { get; set; }

            [global::ProtoBuf.ProtoMember(11, Name = @"error")]
            public global::System.Collections.Generic.List<Trace.Error> Errors { get; } = new global::System.Collections.Generic.List<Trace.Error>();

            [global::ProtoBuf.ProtoMember(12, Name = @"child")]
            public global::System.Collections.Generic.List<Node> Childs { get; } = new global::System.Collections.Generic.List<Node>();

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class QueryPlanNode : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"sequence")]
            public SequenceNode Sequence
            {
                get => __pbn__node.Is(1) ? ((SequenceNode)__pbn__node.Object) : default;
                set => __pbn__node = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
            }
            public bool ShouldSerializeSequence() => __pbn__node.Is(1);
            public void ResetSequence() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__node, 1);

            private global::ProtoBuf.DiscriminatedUnionObject __pbn__node;

            [global::ProtoBuf.ProtoMember(2, Name = @"parallel")]
            public ParallelNode Parallel
            {
                get => __pbn__node.Is(2) ? ((ParallelNode)__pbn__node.Object) : default;
                set => __pbn__node = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
            }
            public bool ShouldSerializeParallel() => __pbn__node.Is(2);
            public void ResetParallel() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__node, 2);

            [global::ProtoBuf.ProtoMember(3, Name = @"fetch")]
            public FetchNode Fetch
            {
                get => __pbn__node.Is(3) ? ((FetchNode)__pbn__node.Object) : default;
                set => __pbn__node = new global::ProtoBuf.DiscriminatedUnionObject(3, value);
            }
            public bool ShouldSerializeFetch() => __pbn__node.Is(3);
            public void ResetFetch() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__node, 3);

            [global::ProtoBuf.ProtoMember(4, Name = @"flatten")]
            public FlattenNode Flatten
            {
                get => __pbn__node.Is(4) ? ((FlattenNode)__pbn__node.Object) : default;
                set => __pbn__node = new global::ProtoBuf.DiscriminatedUnionObject(4, value);
            }
            public bool ShouldSerializeFlatten() => __pbn__node.Is(4);
            public void ResetFlatten() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__node, 4);

            [global::ProtoBuf.ProtoContract()]
            public partial class SequenceNode : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"nodes")]
                public global::System.Collections.Generic.List<Trace.QueryPlanNode> Nodes { get; } = new global::System.Collections.Generic.List<Trace.QueryPlanNode>();

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class ParallelNode : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"nodes")]
                public global::System.Collections.Generic.List<Trace.QueryPlanNode> Nodes { get; } = new global::System.Collections.Generic.List<Trace.QueryPlanNode>();

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class FetchNode : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"service_name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string ServiceName { get; set; } = "";

                [global::ProtoBuf.ProtoMember(2, Name = @"trace_parsing_failed")]
                public bool TraceParsingFailed { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"trace")]
                public Trace Trace { get; set; }

                [global::ProtoBuf.ProtoMember(4, Name = @"sent_time_offset")]
                public ulong SentTimeOffset { get; set; }

                [global::ProtoBuf.ProtoMember(5, Name = @"sent_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
                public global::System.DateTime? SentTime { get; set; }

                [global::ProtoBuf.ProtoMember(6, Name = @"received_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
                public global::System.DateTime? ReceivedTime { get; set; }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class FlattenNode : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"response_path")]
                public global::System.Collections.Generic.List<Trace.QueryPlanNode.ResponsePathElement> ResponsePaths { get; } = new global::System.Collections.Generic.List<Trace.QueryPlanNode.ResponsePathElement>();

                [global::ProtoBuf.ProtoMember(2, Name = @"node")]
                public Trace.QueryPlanNode Node { get; set; }

            }

            [global::ProtoBuf.ProtoContract()]
            public partial class ResponsePathElement : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"field_name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string FieldName
                {
                    get => __pbn__id.Is(1) ? ((string)__pbn__id.Object) : "";
                    set => __pbn__id = new global::ProtoBuf.DiscriminatedUnion32Object(1, value);
                }
                public bool ShouldSerializeFieldName() => __pbn__id.Is(1);
                public void ResetFieldName() => global::ProtoBuf.DiscriminatedUnion32Object.Reset(ref __pbn__id, 1);

                private global::ProtoBuf.DiscriminatedUnion32Object __pbn__id;

                [global::ProtoBuf.ProtoMember(2, Name = @"index")]
                public uint Index
                {
                    get => __pbn__id.Is(2) ? __pbn__id.UInt32 : default;
                    set => __pbn__id = new global::ProtoBuf.DiscriminatedUnion32Object(2, value);
                }
                public bool ShouldSerializeIndex() => __pbn__id.Is(2);
                public void ResetIndex() => global::ProtoBuf.DiscriminatedUnion32Object.Reset(ref __pbn__id, 2);

            }

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ReportHeader : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(5, Name = @"hostname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Hostname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(6, Name = @"agent_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string AgentVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(7, Name = @"service_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ServiceVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8, Name = @"runtime_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RuntimeVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(9, Name = @"uname")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Uname { get; set; } = "";

        [global::ProtoBuf.ProtoMember(10, Name = @"schema_tag")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SchemaTag { get; set; } = "";

        [global::ProtoBuf.ProtoMember(11, Name = @"executable_schema_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExecutableSchemaId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PathErrorStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"children")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, PathErrorStats> Childrens { get; } = new global::System.Collections.Generic.Dictionary<string, PathErrorStats>();

        [global::ProtoBuf.ProtoMember(4, Name = @"errors_count")]
        public ulong ErrorsCount { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"requests_with_errors_count")]
        public ulong RequestsWithErrorsCount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QueryLatencyStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"latency_count", IsPacked = true)]
        public long[] LatencyCounts { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"request_count")]
        public ulong RequestCount { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"cache_hits")]
        public ulong CacheHits { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"persisted_query_hits")]
        public ulong PersistedQueryHits { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"persisted_query_misses")]
        public ulong PersistedQueryMisses { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"cache_latency_count", IsPacked = true)]
        public long[] CacheLatencyCounts { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"root_error_stats")]
        public PathErrorStats RootErrorStats { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"requests_with_errors_count")]
        public ulong RequestsWithErrorsCount { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"public_cache_ttl_count", IsPacked = true)]
        public long[] PublicCacheTtlCounts { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"private_cache_ttl_count", IsPacked = true)]
        public long[] PrivateCacheTtlCounts { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"registered_operation_count")]
        public ulong RegisteredOperationCount { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"forbidden_operation_count")]
        public ulong ForbiddenOperationCount { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StatsContext : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_reference_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientReferenceId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"client_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"client_version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientVersion { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContextualizedQueryLatencyStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"query_latency_stats")]
        public QueryLatencyStats QueryLatencyStats { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"context")]
        public StatsContext Context { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContextualizedTypeStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"context")]
        public StatsContext Context { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"per_type_stat")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, TypeStat> PerTypeStats { get; } = new global::System.Collections.Generic.Dictionary<string, TypeStat>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FieldStat : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(3, Name = @"return_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReturnType { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"errors_count")]
        public ulong ErrorsCount { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"count")]
        public ulong Count { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"requests_with_errors_count")]
        public ulong RequestsWithErrorsCount { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"latency_count", IsPacked = true)]
        public long[] LatencyCounts { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TypeStat : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(3, Name = @"per_field_stat")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, FieldStat> PerFieldStats { get; } = new global::System.Collections.Generic.Dictionary<string, FieldStat>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Field : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"return_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReturnType { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Type : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"field")]
        public global::System.Collections.Generic.List<Field> Fields { get; } = new global::System.Collections.Generic.List<Field>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Report : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"header")]
        public ReportHeader Header { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"traces_per_query")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, TracesAndStats> TracesPerQueries { get; } = new global::System.Collections.Generic.Dictionary<string, TracesAndStats>();

        [global::ProtoBuf.ProtoMember(2, Name = @"end_time", DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
        public global::System.DateTime? EndTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContextualizedStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"context")]
        public StatsContext Context { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"query_latency_stats")]
        public QueryLatencyStats QueryLatencyStats { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"per_type_stat")]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, TypeStat> PerTypeStats { get; } = new global::System.Collections.Generic.Dictionary<string, TypeStat>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TracesAndStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"trace")]
        public global::System.Collections.Generic.List<Trace> Traces { get; } = new global::System.Collections.Generic.List<Trace>();

        [global::ProtoBuf.ProtoMember(2, Name = @"stats_with_context")]
        public global::System.Collections.Generic.List<ContextualizedStats> StatsWithContexts { get; } = new global::System.Collections.Generic.List<ContextualizedStats>();

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion