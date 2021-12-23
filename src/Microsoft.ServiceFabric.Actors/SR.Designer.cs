﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.ServiceFabric.Actors.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor call throttled.
        /// </summary>
        internal static string ActorCallThrottledMessage {
            get {
                return ResourceManager.GetString("ActorCallThrottledMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor id {0} was deleted using DeleteActorAsync while this call was in prgoress. This call should be retried..
        /// </summary>
        internal static string ActorDeletedExceptionMessage {
            get {
                return ResourceManager.GetString("ActorDeletedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to idleTimeoutInSeconds must be greater than or equal to scanIntervalInSeconds.
        /// </summary>
        internal static string ActorGCSettingsNotValid {
            get {
                return ResourceManager.GetString("ActorGCSettingsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified value must be greater than 0..
        /// </summary>
        internal static string ActorGCSettingsValueOutOfRange {
            get {
                return ResourceManager.GetString("ActorGCSettingsValueOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reminders cannot be registered or unregistered on Actor {0} because it doesnt implement IRemindable.
        /// </summary>
        internal static string ActorNotIRemindable {
            get {
                return ResourceManager.GetString("ActorNotIRemindable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method can only be called on ActorProxy..
        /// </summary>
        internal static string ActorProxyOnlyMethod {
            get {
                return ResourceManager.GetString("ActorProxyOnlyMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor state name &apos;{0}&apos; already exist..
        /// </summary>
        internal static string ActorStateAlreadyExists {
            get {
                return ResourceManager.GetString("ActorStateAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Actor state &apos;{0}&apos; was already removed in current call context..
        /// </summary>
        internal static string ActorStateAlreadyRemovedCurrentContext {
            get {
                return ResourceManager.GetString("ActorStateAlreadyRemovedCurrentContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acquisition of turn based concurrency lock for actor &apos;{0}&apos; timed out after {1}..
        /// </summary>
        internal static string ConcurrencyLockTimedOut {
            get {
                return ResourceManager.GetString("ConcurrencyLockTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete request for Actor {0} cannot be processed now since the actor is loading reminders. Please try again later..
        /// </summary>
        internal static string DeleteActorConflictWithLoadReminders {
            get {
                return ResourceManager.GetString("DeleteActorConflictWithLoadReminders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for Continuation token..
        /// </summary>
        internal static string Error_InvalidContinuationToken {
            get {
                return ResourceManager.GetString("Error_InvalidContinuationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor type &apos;{0}&apos; is abstract. Abstract actors cannot be registered as they cannot be instantiated..
        /// </summary>
        internal static string ErrorAbstractActorRegistrationNotAllowed {
            get {
                return ResourceManager.GetString("ErrorAbstractActorRegistrationNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize ActorMessageHeaders.
        /// </summary>
        internal static string ErrorActorMessageHeadersDeserializationFailed {
            get {
                return ResourceManager.GetString("ErrorActorMessageHeadersDeserializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; does not return Task or Task&lt;&gt;. The actor interface methods must be async and must return either Task or Task&lt;&gt;..
        /// </summary>
        internal static string ErrorActorMethodDoesNotReturnTask {
            get {
                return ResourceManager.GetString("ErrorActorMethodDoesNotReturnTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; is using generics. The actor interface methods cannot use generics..
        /// </summary>
        internal static string ErrorActorMethodHasGenerics {
            get {
                return ResourceManager.GetString("ErrorActorMethodHasGenerics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; has out/ref/optional parameter &apos;{2}&apos;. The actor interface methods must not have out, ref or optional parameters..
        /// </summary>
        internal static string ErrorActorMethodHasOutRefOptionalParameter {
            get {
                return ResourceManager.GetString("ErrorActorMethodHasOutRefOptionalParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; has variable length parameter &apos;{2}&apos;. The actor interface methods must not have variable length parameters..
        /// </summary>
        internal static string ErrorActorMethodHasVaArgParameter {
            get {
                return ResourceManager.GetString("ErrorActorMethodHasVaArgParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; is using a variable argument list. The actor interface methods cannot have a variable argument list..
        /// </summary>
        internal static string ErrorActorMethodHasVaArgs {
            get {
                return ResourceManager.GetString("ErrorActorMethodHasVaArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; is overloaded. The actor interface methods cannot be overloaded..
        /// </summary>
        internal static string ErrorActorMethodsIsOverloaded {
            get {
                return ResourceManager.GetString("ErrorActorMethodsIsOverloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor {0} is not found in the input assembly. Ensure that it derives from either {1} or {2} and implements and {3} interface..
        /// </summary>
        internal static string ErrorActorNotFound {
            get {
                return ResourceManager.GetString("ErrorActorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&lt;{1}&gt;: Actor state must have a callable constructor and be serializable.&quot;.
        /// </summary>
        internal static string ErrorActorStateNotSerializable {
            get {
                return ResourceManager.GetString("ErrorActorStateNotSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to determine the current application, please provide application name..
        /// </summary>
        internal static string ErrorApplicationName {
            get {
                return ResourceManager.GetString("ErrorApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not cast {0} to {1}..
        /// </summary>
        internal static string ErrorCasting {
            get {
                return ResourceManager.GetString("ErrorCasting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize and get remote exception..
        /// </summary>
        internal static string ErrorDeserializeRemoteException {
            get {
                return ResourceManager.GetString("ErrorDeserializeRemoteException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor {0}  got same request more than once. This might happen for a request which takes more processing time than configured OperationTimeout 
        ///    on Client side as client retries on TimeoutException..
        /// </summary>
        internal static string ErrorDuplicateMessage {
            get {
                return ResourceManager.GetString("ErrorDuplicateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot determine the event interface from the supplied generic type argument. Supply the event interface type..
        /// </summary>
        internal static string ErrorEventInterface {
            get {
                return ResourceManager.GetString("ErrorEventInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0} is not an actor events interface. The actor event interface must only derive from &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorEventInterfaceMustBeIActorEvents {
            get {
                return ResourceManager.GetString("ErrorEventInterfaceMustBeIActorEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor interface &apos;{1}&apos; returns &apos;{2}. The actor event interface methods must not return anything. The return type must be &apos;{3}&apos;..
        /// </summary>
        internal static string ErrorEventMethodDoesNotReturnVoid {
            get {
                return ResourceManager.GetString("ErrorEventMethodDoesNotReturnVoid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor event interface &apos;{1}&apos; is using generics. The actor event interface methods cannot use generics..
        /// </summary>
        internal static string ErrorEventMethodHasGenerics {
            get {
                return ResourceManager.GetString("ErrorEventMethodHasGenerics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor event interface &apos;{1}&apos; has out/ref/optional parameter &apos;{2}&apos;. The actor event interface methods must not have out, ref or optional parameters..
        /// </summary>
        internal static string ErrorEventMethodHasOutRefOptionalParameter {
            get {
                return ResourceManager.GetString("ErrorEventMethodHasOutRefOptionalParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor event interface &apos;{1}&apos; has variable length parameter &apos;{2}&apos;. The actor event interface methods must not have variable length parameters..
        /// </summary>
        internal static string ErrorEventMethodHasVaArgParameter {
            get {
                return ResourceManager.GetString("ErrorEventMethodHasVaArgParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor event interface &apos;{1}&apos; is using a variable argument list. The actor event interface methods cannot have a variable argument list..
        /// </summary>
        internal static string ErrorEventMethodHasVaArgs {
            get {
                return ResourceManager.GetString("ErrorEventMethodHasVaArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; of actor event interface &apos;{1}&apos; is overloaded. The actor event interface methods cannot be overloaded..
        /// </summary>
        internal static string ErrorEventMethodsIsOverloaded {
            get {
                return ResourceManager.GetString("ErrorEventMethodsIsOverloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event with eventId &apos;{0}&apos; is not supported by Actor with actorId &apos;{1}&apos; .
        /// </summary>
        internal static string ErrorEventNotSupportedByActor {
            get {
                return ResourceManager.GetString("ErrorEventNotSupportedByActor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HighestSequenceNumber({0}) &lt; UpToSequenceNumber({1}).
        /// </summary>
        internal static string ErrorHighestSequenceNumberLessThanUpToSequenceNumber {
            get {
                return ResourceManager.GetString("ErrorHighestSequenceNumberLessThanUpToSequenceNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method Id &apos;{0}&apos; is not available for ActorEventSubscription.
        /// </summary>
        internal static string ErrorInvalidMethodId {
            get {
                return ResourceManager.GetString("ErrorInvalidMethodId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid ReminderAttribute..
        /// </summary>
        internal static string ErrorInvalidReminderAttribute {
            get {
                return ResourceManager.GetString("ErrorInvalidReminderAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No MethodDispatcher is found for interface id &apos;{0}&apos;.
        /// </summary>
        internal static string ErrorMethodDispatcherNotFound {
            get {
                return ResourceManager.GetString("ErrorMethodDispatcherNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; method is not supported for type &apos;{1}&apos;.
        /// </summary>
        internal static string ErrorMethodNotSupported {
            get {
                return ResourceManager.GetString("ErrorMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; must implement only one actor interface..
        /// </summary>
        internal static string ErrorMoreThanOneActorInterfaceFound {
            get {
                return ResourceManager.GetString("ErrorMoreThanOneActorInterfaceFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor State with name {0} was not found..
        /// </summary>
        internal static string ErrorNamedActorStateNotFound {
            get {
                return ResourceManager.GetString("ErrorNamedActorStateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor type &apos;{0}&apos; does not implement any actor interfaces or one of the interfaces implemented is not an actor interface. All interfaces(including its parent interface) implemented by actor type must be actor interface. An actor interface is the one that ultimately derives from &apos;{1}&apos; type..
        /// </summary>
        internal static string ErrorNoActorInterfaceFound {
            get {
                return ResourceManager.GetString("ErrorNoActorInterfaceFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor interface {0} is implemented by actor types {1} and {2}. In order for the client to connect to the right actor, please add {3} attribute with valid Name on the both actor types. Please use this Name as serviceName parameter when creating ActorProxy. .
        /// </summary>
        internal static string ErrorNoActorServiceNameMultipleImpl {
            get {
                return ResourceManager.GetString("ErrorNoActorServiceNameMultipleImpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor type {1} is inherited from actor type {2}. Therefore the actor interface {0} has multiple implementation. In order for the client to connect to the right actor, please add {3} attribute with valid Name on the both actor types. Please use this Name as serviceName parameter when creating ActorProxy. If the actor type {1} should not be instantiated, please make it abstract..
        /// </summary>
        internal static string ErrorNoActorServiceNameMultipleImplDerivation {
            get {
                return ResourceManager.GetString("ErrorNoActorServiceNameMultipleImplDerivation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actor type {0} implements more than one actor interfaces. In order for the client to connect to the right actor, please add {1} attribute with valid Name on the actor type. Please use this Name as serviceName parameter when creating ActorProxy..
        /// </summary>
        internal static string ErrorNoActorServiceNameMultipleInterfaces {
            get {
                return ResourceManager.GetString("ErrorNoActorServiceNameMultipleInterfaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor state has no callable constructors with default argument values.
        /// </summary>
        internal static string ErrorNoActorStateCallableConstructors {
            get {
                return ResourceManager.GetString("ErrorNoActorStateCallableConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor state has no constructors.
        /// </summary>
        internal static string ErrorNoActorStateConstructors {
            get {
                return ResourceManager.GetString("ErrorNoActorStateConstructors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not an Actor. An actor type must derive from &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorNotAnActor {
            get {
                return ResourceManager.GetString("ErrorNotAnActor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not an actor interface as it does not derive from the interface &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorNotAnActorInterface_DerivationCheck1 {
            get {
                return ResourceManager.GetString("ErrorNotAnActorInterface_DerivationCheck1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not an actor interface as it derive from a non actor interface &apos;{1}&apos;. All actor interfaces must derive from &apos;{2}&apos;..
        /// </summary>
        internal static string ErrorNotAnActorInterface_DerivationCheck2 {
            get {
                return ResourceManager.GetString("ErrorNotAnActorInterface_DerivationCheck2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not an Actor interface as it is not an interface. .
        /// </summary>
        internal static string ErrorNotAnActorInterface_InterfaceCheck {
            get {
                return ResourceManager.GetString("ErrorNotAnActorInterface_InterfaceCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OnDataLossAsync can only be set once..
        /// </summary>
        internal static string ErrorOnDataLossAsyncReset {
            get {
                return ResourceManager.GetString("ErrorOnDataLossAsyncReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OnRestoreCompletedAsync can only be set once..
        /// </summary>
        internal static string ErrorOnRestoreCompletedAsyncReset {
            get {
                return ResourceManager.GetString("ErrorOnRestoreCompletedAsyncReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Null {0} in replicator settings.
        /// </summary>
        internal static string ErrorReplicatorSettings {
            get {
                return ResourceManager.GetString("ErrorReplicatorSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor activated. Actor type: {0}, actor ID: {1}, replica/instance ID: {3}, partition ID: {4}..
        /// </summary>
        internal static string event_ActorActivated {
            get {
                return ResourceManager.GetString("event_ActorActivated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor deactivated. Actor type: {0}, actor ID: {1},  replica/instance ID: {3}, partition ID: {4}..
        /// </summary>
        internal static string event_ActorDeactivated {
            get {
                return ResourceManager.GetString("event_ActorDeactivated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of actor method calls waiting for the actor lock: {0}, actor type: {1}, actor ID: {2}..
        /// </summary>
        internal static string event_ActorMethodCallsWaitingForLock {
            get {
                return ResourceManager.GetString("event_ActorMethodCallsWaitingForLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor method is being invoked. Method name: {0}, actor type: {2}, actor ID: {3}..
        /// </summary>
        internal static string event_ActorMethodStart {
            get {
                return ResourceManager.GetString("event_ActorMethodStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor method has completed. Method name: {1}, actor type: {3}, actor ID: {4}..
        /// </summary>
        internal static string event_ActorMethodStop {
            get {
                return ResourceManager.GetString("event_ActorMethodStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor&apos;s async method threw an exception. Method name: {2}, actor type: {4}, actor ID: {5}, exception: {0}..
        /// </summary>
        internal static string event_ActorMethodThrewException {
            get {
                return ResourceManager.GetString("event_ActorMethodThrewException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting to save actor state. Actor type: {0}, actor ID: {1}..
        /// </summary>
        internal static string event_ActorSaveStateStart {
            get {
                return ResourceManager.GetString("event_ActorSaveStateStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished saving actor state. Actor type: {1}, actor ID: {2}..
        /// </summary>
        internal static string event_ActorSaveStateStop {
            get {
                return ResourceManager.GetString("event_ActorSaveStateStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor type {0} registered..
        /// </summary>
        internal static string event_ActorTypeRegistered {
            get {
                return ResourceManager.GetString("event_ActorTypeRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to register actor type {1}. Exception: {0}..
        /// </summary>
        internal static string event_ActorTypeRegistrationFailed {
            get {
                return ResourceManager.GetString("event_ActorTypeRegistrationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor replica changed role to non-Primary. Replica ID: {0}, partition ID: {1}..
        /// </summary>
        internal static string event_ReplicaChangeRoleFromPrimary {
            get {
                return ResourceManager.GetString("event_ReplicaChangeRoleFromPrimary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor replica changed role to Primary. Replica ID: {0}, partition ID: {1}..
        /// </summary>
        internal static string event_ReplicaChangeRoleToPrimary {
            get {
                return ResourceManager.GetString("event_ReplicaChangeRoleToPrimary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; is not valid for &apos;{1}&apos; ActorId..
        /// </summary>
        internal static string InvalidActorKind {
            get {
                return ResourceManager.GetString("InvalidActorKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call context does not match current call context.
        /// </summary>
        internal static string InvalidCallContextReleased {
            get {
                return ResourceManager.GetString("InvalidCallContextReleased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for argument IsReadOnly &apos;{0}&apos; for non-existing Actor state &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidIsReadOnlyNonExistingActorState {
            get {
                return ResourceManager.GetString("InvalidIsReadOnlyNonExistingActorState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor {0} can be decorated with atmost one Reentrancy attribute.
        /// </summary>
        internal static string InvalidReentrancyConfiguration {
            get {
                return ResourceManager.GetString("InvalidReentrancyConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reentrant call has been made from actor while there are other outstanding actor calls. Atmost one reentrant call is allowed at a time..
        /// </summary>
        internal static string InvalidReentrantCall {
            get {
                return ResourceManager.GetString("InvalidReentrantCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StateChangeKind can  only  be add, update or remove..
        /// </summary>
        internal static string InvalidStateChangeKind {
            get {
                return ResourceManager.GetString("InvalidStateChangeKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ActorMethod.
        /// </summary>
        internal static string keyword_ActorMethod {
            get {
                return ResourceManager.GetString("keyword_ActorMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ActorState.
        /// </summary>
        internal static string keyword_ActorState {
            get {
                return ResourceManager.GetString("keyword_ActorState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default.
        /// </summary>
        internal static string keyword_Default {
            get {
                return ResourceManager.GetString("keyword_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MetricActorMethodCallsWaitingForLock.
        /// </summary>
        internal static string keyword_MetricActorMethodCallsWaitingForLock {
            get {
                return ResourceManager.GetString("keyword_MetricActorMethodCallsWaitingForLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actor {0} does not allow reentrant calls. ReentrancyMode must be set to LogicalCallContext to allow reentrant calls.
        /// </summary>
        internal static string ReentrancyModeDisallowed {
            get {
                return ResourceManager.GetString("ReentrancyModeDisallowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reentrant call to Actor {0} found its state to be dirty. This typically indicates programming error..
        /// </summary>
        internal static string ReentrantActorDirtyState {
            get {
                return ResourceManager.GetString("ReentrantActorDirtyState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reminder {0} was not found for Actor {1}.
        /// </summary>
        internal static string ReminderNotFound {
            get {
                return ResourceManager.GetString("ReminderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reminder cannot be registered for type {0} because the class does not implement {1}.
        /// </summary>
        internal static string ReminderNotSupported {
            get {
                return ResourceManager.GetString("ReminderNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Content..
        /// </summary>
        internal static string ScriptGeneratorInvalidContent {
            get {
                return ResourceManager.GetString("ScriptGeneratorInvalidContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TimeSpan TotalMilliseconds specified value must be between {0} and {1} .
        /// </summary>
        internal static string TimerArgumentOutOfRange {
            get {
                return ResourceManager.GetString("TimerArgumentOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system has a counter with the same category and counter name, but its counter type is not what we expect..
        /// </summary>
        internal static string UnexpectedCounterType {
            get {
                return ResourceManager.GetString("UnexpectedCounterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reminder {0} for Actor {1} cannot be registered or unregistered since the actor is loading reminders. Please try again later..
        /// </summary>
        internal static string UnregisterReminderConflict {
            get {
                return ResourceManager.GetString("UnregisterReminderConflict", resourceCulture);
            }
        }
    }
}
