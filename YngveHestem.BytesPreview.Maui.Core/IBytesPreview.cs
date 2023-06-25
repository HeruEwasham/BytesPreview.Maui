﻿using YngveHestem.FileTypeInfo;

namespace YngveHestem.BytesPreview.Maui.Core;

// All the code in this file is included in all platforms.
public interface IBytesPreview
{
    /// <summary>
    /// Check if the given exteension/bytes can be previewed by this implementation.
    /// </summary>
    /// <param name="fileType">The given filetype supported. This parameter can also be null, but then the given bytes are the only way the implementation can know if this is possible. As it is difficult to know if a byte-array is supported by it´s own, an implementation can decide to only look at the extensions. Therefore this should if possible both be provided and should be correct.</param>
    /// <param name="bytes">The bytes to possibly preview. Mark that it both can be given null or empty bytes-array. This means that the implementation can decide if it want to deal with that or just say no.</param>
    /// <returns>True if the given implementation thinks it can handle the file or false if it does not think it can handle it</returns>
    bool CanPreviewBytes(FileType fileType, byte[] bytes);

    /// <summary>
    /// Preview the given bytes. The control returned should contain all needed information.
    /// </summary>
    /// <param name="fileType">The given fileType. The implementation may need this.</param>
    /// <param name="bytes">The bytes to preview.</param>
    /// <returns></returns>
    View GetPreviewControl(FileType fileType, byte[] bytes);
}

