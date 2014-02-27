
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Nest.Resolvers;

///This file contains all the typed querystring parameters that are generated of the client spec.
///This file is automatically generated from https://github.com/elasticsearch/elasticsearch-rest-api-spec
///Generated of commit 

namespace Nest
{
	public static class QueryStringPameterExtensions
	{
		
		///<summary>A comma-separated list of fields to return in the response</summary>
			internal static ExplainQueryString _Fields<T>(
				this ExplainQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to return in the response</summary>
			internal static GetQueryString _Fields<T>(
				this GetQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>Use the analyzer configured for this field (instead of passing the analyzer name)</summary>
			internal static AnalyzeQueryString _Field<T>(
				this AnalyzeQueryString qs,
				Expression<Func<T, object>> field)
			where T : class
		{
			var p = (PropertyPathMarker)field;
			qs._field = p;
			qs.Add("field", qs._field);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to clear when using the `field_data` parameter (default: all)</summary>
			internal static ClearCacheQueryString _Fields<T>(
				this ClearCacheQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
			internal static IndicesStatsQueryString _CompletionFields<T>(
				this IndicesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  completion_fields)
			where T : class
		{
			qs._completion_fields = completion_fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("completion_fields", qs._completion_fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
			internal static IndicesStatsQueryString _FielddataFields<T>(
				this IndicesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fielddata_fields)
			where T : class
		{
			qs._fielddata_fields = fielddata_fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fielddata_fields", qs._fielddata_fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
			internal static IndicesStatsQueryString _Fields<T>(
				this IndicesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to return in the response</summary>
			internal static MultiGetQueryString _Fields<T>(
				this MultiGetQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>Specific fields to perform the query against</summary>
			internal static MoreLikeThisQueryString _MltFields<T>(
				this MoreLikeThisQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  mlt_fields)
			where T : class
		{
			qs._mlt_fields = mlt_fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("mlt_fields", qs._mlt_fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body &quot;params&quot; or &quot;docs&quot;.</summary>
			internal static MtermvectorsQueryString _Fields<T>(
				this MtermvectorsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
			internal static NodesStatsQueryString _CompletionFields<T>(
				this NodesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  completion_fields)
			where T : class
		{
			qs._completion_fields = completion_fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("completion_fields", qs._completion_fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
			internal static NodesStatsQueryString _FielddataFields<T>(
				this NodesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fielddata_fields)
			where T : class
		{
			qs._fielddata_fields = fielddata_fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fielddata_fields", qs._fielddata_fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
			internal static NodesStatsQueryString _Fields<T>(
				this NodesStatsQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>Specify which field to use for suggestions</summary>
			internal static SearchQueryString _SuggestField<T>(
				this SearchQueryString qs,
				Expression<Func<T, object>> suggest_field)
			where T : class
		{
			var p = (PropertyPathMarker)suggest_field;
			qs._suggest_field = p;
			qs.Add("suggest_field", qs._suggest_field);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to return.</summary>
			internal static TermvectorQueryString _Fields<T>(
				this TermvectorQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
		
		///<summary>A comma-separated list of fields to return in the response</summary>
			internal static UpdateQueryString _Fields<T>(
				this UpdateQueryString qs,
				IEnumerable<Expression<Func<T, object>>>  fields)
			where T : class
		{
			qs._fields = fields.Select(e=>(PropertyPathMarker)e);
			qs.Add("fields", qs._fields);
			return qs;
		}
		
}
}
 