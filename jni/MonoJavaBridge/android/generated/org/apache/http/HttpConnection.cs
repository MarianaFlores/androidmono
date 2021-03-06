namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnection_))]
	public interface HttpConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void shutdown();
		void close();
		bool isOpen();
		global::org.apache.http.HttpConnectionMetrics getMetrics();
		bool isStale();
		void setSocketTimeout(int arg0);
		int getSocketTimeout();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnection))]
	public sealed partial class HttpConnection_ : java.lang.Object, HttpConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnection_()
		{
			InitJNI();
		}
		internal HttpConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown16133;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._shutdown16133);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._shutdown16133);
		}
		internal static global::MonoJavaBridge.MethodId _close16134;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._close16134);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._close16134);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16135;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._isOpen16135);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._isOpen16135);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics16136;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._getMetrics16136)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._getMetrics16136)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale16137;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._isStale16137);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._isStale16137);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout16138;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._setSocketTimeout16138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._setSocketTimeout16138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout16139;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._getSocketTimeout16139);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._getSocketTimeout16139);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnection"));
			global::org.apache.http.HttpConnection_._shutdown16133 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpConnection_._close16134 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpConnection_._isOpen16135 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpConnection_._getMetrics16136 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpConnection_._isStale16137 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpConnection_._setSocketTimeout16138 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpConnection_._getSocketTimeout16139 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
