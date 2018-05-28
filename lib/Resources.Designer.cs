﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.DataMovement {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.Storage.DataMovement.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AppendBlob.
        /// </summary>
        internal static string AppendBlob {
            get {
                return ResourceManager.GetString("AppendBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying from File Storage to append Blob Storage asynchronously is not supported..
        /// </summary>
        internal static string AsyncCopyFromFileToAppendBlobNotSupportException {
            get {
                return ResourceManager.GetString("AsyncCopyFromFileToAppendBlobNotSupportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying from File Storage to page Blob Storage asynchronously is not supported..
        /// </summary>
        internal static string AsyncCopyFromFileToPageBlobNotSupportException {
            get {
                return ResourceManager.GetString("AsyncCopyFromFileToPageBlobNotSupportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AzureFile.
        /// </summary>
        internal static string AzureFile {
            get {
                return ResourceManager.GetString("AzureFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size {0} is invalid for {1}, must be a multiple of {2}..
        /// </summary>
        internal static string BlobFileSizeInvalidException {
            get {
                return ResourceManager.GetString("BlobFileSizeInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size {0} is larger than {1} maximum size {2}..
        /// </summary>
        internal static string BlobFileSizeTooLargeException {
            get {
                return ResourceManager.GetString("BlobFileSizeTooLargeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BlockBlob.
        /// </summary>
        internal static string BlockBlob {
            get {
                return ResourceManager.GetString("BlockBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BlockSize must be multiple of 4MB..
        /// </summary>
        internal static string BlockSizeMustBeMultipleOf4MB {
            get {
                return ResourceManager.GetString("BlockSizeMustBeMultipleOf4MB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BlockSize must be between {0} and {1}..
        /// </summary>
        internal static string BlockSizeOutOfRangeException {
            get {
                return ResourceManager.GetString("BlockSizeOutOfRangeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot deserialize to TransferLocation when its TransferLocationType is {0}..
        /// </summary>
        internal static string CannotDeserializeLocationType {
            get {
                return ResourceManager.GetString("CannotDeserializeLocationType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TransferLocation cannot be serialized when it represents a stream location..
        /// </summary>
        internal static string CannotSerializeStreamLocation {
            get {
                return ResourceManager.GetString("CannotSerializeStreamLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination of asynchronous copying must be File Storage or Blob Storage..
        /// </summary>
        internal static string CanOnlyCopyToFileOrBlobException {
            get {
                return ResourceManager.GetString("CanOnlyCopyToFileOrBlobException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size {0} is larger than cloud file maximum size {1} bytes..
        /// </summary>
        internal static string CloudFileSizeTooLargeException {
            get {
                return ResourceManager.GetString("CloudFileSizeTooLargeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential dead loop in directory structure due to symbolic link {0} with target to {1}.
        /// </summary>
        internal static string DeadLoop {
            get {
                return ResourceManager.GetString("DeadLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Deserialization failed: Version number doesn&apos;t match. Version number:{1}, expect:{2}..
        /// </summary>
        internal static string DeserializationVersionNotMatchException {
            get {
                return ResourceManager.GetString("DeserializationVersionNotMatchException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User specified blob type does not match the blob type of the existing destination blob..
        /// </summary>
        internal static string DestinationBlobTypeNotMatch {
            get {
                return ResourceManager.GetString("DestinationBlobTypeNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination might be changed by other process or application..
        /// </summary>
        internal static string DestinationChangedException {
            get {
                return ResourceManager.GetString("DestinationChangedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination must be a base blob..
        /// </summary>
        internal static string DestinationMustBeBaseBlob {
            get {
                return ResourceManager.GetString("DestinationMustBeBaseBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MD5 hash calculated from the downloaded data does not match the MD5 hash stored in the property of source: {0}. Please refer to help or documentation for detail.
        ///MD5 calculated: {1}
        ///MD5 in property: {2}.
        /// </summary>
        internal static string DownloadedMd5MismatchException {
            get {
                return ResourceManager.GetString("DownloadedMd5MismatchException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to enumerate directory {0}..
        /// </summary>
        internal static string EnumerateDirectoryException {
            get {
                return ResourceManager.GetString("EnumerateDirectoryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to allocate required memory..
        /// </summary>
        internal static string FailedToAllocateMemoryException {
            get {
                return ResourceManager.GetString("FailedToAllocateMemoryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to copy from &quot;{0}&quot; to &quot;{1}&quot;. Copy status: {2}; Description: {3}..
        /// </summary>
        internal static string FailedToAsyncCopyObjectException {
            get {
                return ResourceManager.GetString("FailedToAsyncCopyObjectException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to enumerate directory {0} with file pattern {1}..
        /// </summary>
        internal static string FailedToEnumerateDirectory {
            get {
                return ResourceManager.GetString("FailedToEnumerateDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve the original BlobType..
        /// </summary>
        internal static string FailedToGetBlobTypeException {
            get {
                return ResourceManager.GetString("FailedToGetBlobTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to open file {0}: {1}..
        /// </summary>
        internal static string FailedToOpenFileException {
            get {
                return ResourceManager.GetString("FailedToOpenFileException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve CopyState for object &quot;{0}&quot;..
        /// </summary>
        internal static string FailedToRetrieveCopyStateForObjectException {
            get {
                return ResourceManager.GetString("FailedToRetrieveCopyStateForObjectException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to validate destination..
        /// </summary>
        internal static string FailedToValidateDestinationException {
            get {
                return ResourceManager.GetString("FailedToValidateDestinationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path, file name, or both are too long for file: &quot;{0}&quot;.
        /// </summary>
        internal static string FilePathTooLong {
            get {
                return ResourceManager.GetString("FilePathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The initial entry status {0} is invalid for {1}..
        /// </summary>
        internal static string InvalidInitialEntryStatusForControllerException {
            get {
                return ResourceManager.GetString("InvalidInitialEntryStatusForControllerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both Source and Destination are locally accessible locations. At least one of source and destination should be an Azure Storage location..
        /// </summary>
        internal static string LocalToLocalTransferUnsupportedException {
            get {
                return ResourceManager.GetString("LocalToLocalTransferUnsupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local copy id is different from the one returned from the server..
        /// </summary>
        internal static string MismatchFoundBetweenLocalAndServerCopyIdsException {
            get {
                return ResourceManager.GetString("MismatchFoundBetweenLocalAndServerCopyIdsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blob type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string NotSupportedBlobType {
            get {
                return ResourceManager.GetString("NotSupportedBlobType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one transfer is allowed with stream journal..
        /// </summary>
        internal static string OnlyOneTransferAllowed {
            get {
                return ResourceManager.GetString("OnlyOneTransferAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skiped file &quot;{0}&quot; because target &quot;{1}&quot; already exists..
        /// </summary>
        internal static string OverwriteCallbackCancelTransferException {
            get {
                return ResourceManager.GetString("OverwriteCallbackCancelTransferException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PageBlob.
        /// </summary>
        internal static string PageBlob {
            get {
                return ResourceManager.GetString("PageBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parallel operations count must be positive..
        /// </summary>
        internal static string ParallelCountNotPositiveException {
            get {
                return ResourceManager.GetString("ParallelCountNotPositiveException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be null..
        /// </summary>
        internal static string ParameterCannotBeNullException {
            get {
                return ResourceManager.GetString("ParameterCannotBeNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the path &apos;{0}&apos;..
        /// </summary>
        internal static string PathNotFound {
            get {
                return ResourceManager.GetString("PathNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exactly one of these parameters must be provided: {0}, {1}, {2}..
        /// </summary>
        internal static string ProvideExactlyOneOfThreeParameters {
            get {
                return ResourceManager.GetString("ProvideExactlyOneOfThreeParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##} bytes.
        /// </summary>
        internal static string ReadableSizeFormatBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}EB.
        /// </summary>
        internal static string ReadableSizeFormatExaBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatExaBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}GB.
        /// </summary>
        internal static string ReadableSizeFormatGigaBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatGigaBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}KB.
        /// </summary>
        internal static string ReadableSizeFormatKiloBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatKiloBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}MB.
        /// </summary>
        internal static string ReadableSizeFormatMegaBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatMegaBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}PB.
        /// </summary>
        internal static string ReadableSizeFormatPetaBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatPetaBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.##}TB.
        /// </summary>
        internal static string ReadableSizeFormatTeraBytes {
            get {
                return ResourceManager.GetString("ReadableSizeFormatTeraBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} is too long, relative path must not exceed 1024 characters. .
        /// </summary>
        internal static string RelativePathTooLong {
            get {
                return ResourceManager.GetString("RelativePathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read restartable info from file..
        /// </summary>
        internal static string RestartableInfoCorruptedException {
            get {
                return ResourceManager.GetString("RestartableInfoCorruptedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The journal stream is corrupted..
        /// </summary>
        internal static string RestartableLogCorrupted {
            get {
                return ResourceManager.GetString("RestartableLogCorrupted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resuming transfer from or to a stream is not supported. .
        /// </summary>
        internal static string ResumeStreamTransferNotSupported {
            get {
                return ResourceManager.GetString("ResumeStreamTransferNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search pattern is not supported in recursive mode when the source is an Azure file directory..
        /// </summary>
        internal static string SearchPatternInRecursiveModeFromAzureFileNotSupportedException {
            get {
                return ResourceManager.GetString("SearchPatternInRecursiveModeFromAzureFileNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MaximumCacheSize cannot be less than {0}..
        /// </summary>
        internal static string SmallMemoryCacheSizeLimitationException {
            get {
                return ResourceManager.GetString("SmallMemoryCacheSizeLimitationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blob type of source and destination must be the same..
        /// </summary>
        internal static string SourceAndDestinationBlobTypeDifferent {
            get {
                return ResourceManager.GetString("SourceAndDestinationBlobTypeDifferent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source and destination cannot be the same..
        /// </summary>
        internal static string SourceAndDestinationLocationCannotBeEqualException {
            get {
                return ResourceManager.GetString("SourceAndDestinationLocationCannotBeEqualException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source blob does not exist..
        /// </summary>
        internal static string SourceBlobDoesNotExistException {
            get {
                return ResourceManager.GetString("SourceBlobDoesNotExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User specified blob type does not match the blob type of the existing source blob..
        /// </summary>
        internal static string SourceBlobTypeNotMatch {
            get {
                return ResourceManager.GetString("SourceBlobTypeNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source might be changed by other process or application..
        /// </summary>
        internal static string SourceChangedException {
            get {
                return ResourceManager.GetString("SourceChangedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source does not exist..
        /// </summary>
        internal static string SourceDoesNotExistException {
            get {
                return ResourceManager.GetString("SourceDoesNotExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source must be fixed size when destination is {0}.
        /// </summary>
        internal static string SourceMustBeFixedSize {
            get {
                return ResourceManager.GetString("SourceMustBeFixedSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The corresponding destination path for source &quot;{0}&quot; is invalid in Windows system..
        /// </summary>
        internal static string SourceNameInvalidInFileSystem {
            get {
                return ResourceManager.GetString("SourceNameInvalidInFileSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must support Read..
        /// </summary>
        internal static string StreamMustSupportReadException {
            get {
                return ResourceManager.GetString("StreamMustSupportReadException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must support Seek..
        /// </summary>
        internal static string StreamMustSupportSeekException {
            get {
                return ResourceManager.GetString("StreamMustSupportSeekException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must support Write..
        /// </summary>
        internal static string StreamMustSupportWriteException {
            get {
                return ResourceManager.GetString("StreamMustSupportWriteException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream is not expandable..
        /// </summary>
        internal static string StreamNotExpandable {
            get {
                return ResourceManager.GetString("StreamNotExpandable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} sub transfer(s) failed. .
        /// </summary>
        internal static string SubTransferFailsException {
            get {
                return ResourceManager.GetString("SubTransferFailsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying from uri to Azure Blob Storage synchronously is not supported..
        /// </summary>
        internal static string SyncCopyFromUriToAzureBlobNotSupportedException {
            get {
                return ResourceManager.GetString("SyncCopyFromUriToAzureBlobNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying from uri to Azure File Storage synchronously is not supported..
        /// </summary>
        internal static string SyncCopyFromUriToAzureFileNotSupportedException {
            get {
                return ResourceManager.GetString("SyncCopyFromUriToAzureFileNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A transfer operation with the same source and destination already exists..
        /// </summary>
        internal static string TransferAlreadyExists {
            get {
                return ResourceManager.GetString("TransferAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The transfer has been cancelled..
        /// </summary>
        internal static string TransferCancelledException {
            get {
                return ResourceManager.GetString("TransferCancelledException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransferEntry.CopyId cannot be null or empty because we need it to verify we are monitoring the right blob copying process..
        /// </summary>
        internal static string TransferEntryCopyIdCannotBeNullOrEmptyException {
            get {
                return ResourceManager.GetString("TransferEntryCopyIdCannotBeNullOrEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load a dll, this might because the target dll is located on a disk without exec permission..
        /// </summary>
        internal static string UnableToLoadDLL {
            get {
                return ResourceManager.GetString("UnableToLoadDLL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The transfer failed..
        /// </summary>
        internal static string UncategorizedException {
            get {
                return ResourceManager.GetString("UncategorizedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given blob type {0} is not supported..
        /// </summary>
        internal static string UnsupportedBlobTypeException {
            get {
                return ResourceManager.GetString("UnsupportedBlobTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given transfer location type {0} is not supported..
        /// </summary>
        internal static string UnsupportedTransferLocationException {
            get {
                return ResourceManager.GetString("UnsupportedTransferLocationException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Not enough buffer space to write the requested data
        /// </summary>
        internal static string InsufficientBufferSpaceException {
            get {
                return ResourceManager.GetString("InsufficientBufferSpaceException", resourceCulture);
            }
        }
    }
}
