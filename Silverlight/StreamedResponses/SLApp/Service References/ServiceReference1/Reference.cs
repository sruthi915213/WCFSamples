﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50401.0
// 
namespace SLApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ServiceReference1.IWcfDownloadService")]
    public interface IWcfDownloadService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://my.company.com/download", ReplyAction="http://my.company.com/download")]
        System.IAsyncResult BeginDownload(string fileName, long fileSize, System.AsyncCallback callback, object asyncState);
        
        byte[] EndDownload(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfDownloadServiceChannel : SLApp.ServiceReference1.IWcfDownloadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfDownloadServiceClient : System.ServiceModel.ClientBase<SLApp.ServiceReference1.IWcfDownloadService>, SLApp.ServiceReference1.IWcfDownloadService {
        
        private BeginOperationDelegate onBeginDownloadDelegate;
        
        private EndOperationDelegate onEndDownloadDelegate;
        
        private System.Threading.SendOrPostCallback onDownloadCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WcfDownloadServiceClient() {
        }
        
        public WcfDownloadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfDownloadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfDownloadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfDownloadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<DownloadCompletedEventArgs> DownloadCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SLApp.ServiceReference1.IWcfDownloadService.BeginDownload(string fileName, long fileSize, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDownload(fileName, fileSize, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        byte[] SLApp.ServiceReference1.IWcfDownloadService.EndDownload(System.IAsyncResult result) {
            return base.Channel.EndDownload(result);
        }
        
        private System.IAsyncResult OnBeginDownload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string fileName = ((string)(inValues[0]));
            long fileSize = ((long)(inValues[1]));
            return ((SLApp.ServiceReference1.IWcfDownloadService)(this)).BeginDownload(fileName, fileSize, callback, asyncState);
        }
        
        private object[] OnEndDownload(System.IAsyncResult result) {
            byte[] retVal = ((SLApp.ServiceReference1.IWcfDownloadService)(this)).EndDownload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDownloadCompleted(object state) {
            if ((this.DownloadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DownloadCompleted(this, new DownloadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DownloadAsync(string fileName, long fileSize) {
            this.DownloadAsync(fileName, fileSize, null);
        }
        
        public void DownloadAsync(string fileName, long fileSize, object userState) {
            if ((this.onBeginDownloadDelegate == null)) {
                this.onBeginDownloadDelegate = new BeginOperationDelegate(this.OnBeginDownload);
            }
            if ((this.onEndDownloadDelegate == null)) {
                this.onEndDownloadDelegate = new EndOperationDelegate(this.OnEndDownload);
            }
            if ((this.onDownloadCompletedDelegate == null)) {
                this.onDownloadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDownloadCompleted);
            }
            base.InvokeAsync(this.onBeginDownloadDelegate, new object[] {
                        fileName,
                        fileSize}, this.onEndDownloadDelegate, this.onDownloadCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SLApp.ServiceReference1.IWcfDownloadService CreateChannel() {
            return new WcfDownloadServiceClientChannel(this);
        }
        
        private class WcfDownloadServiceClientChannel : ChannelBase<SLApp.ServiceReference1.IWcfDownloadService>, SLApp.ServiceReference1.IWcfDownloadService {
            
            public WcfDownloadServiceClientChannel(System.ServiceModel.ClientBase<SLApp.ServiceReference1.IWcfDownloadService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDownload(string fileName, long fileSize, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = fileName;
                _args[1] = fileSize;
                System.IAsyncResult _result = base.BeginInvoke("Download", _args, callback, asyncState);
                return _result;
            }
            
            public byte[] EndDownload(System.IAsyncResult result) {
                object[] _args = new object[0];
                byte[] _result = ((byte[])(base.EndInvoke("Download", _args, result)));
                return _result;
            }
        }
    }
}
