' / --------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : mailto:thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Create QRCode (2D) with ZXing.Net.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------

'// ZXing.Net release download.
'// https://github.com/micjahn/ZXing.Net/releases

Imports System.Drawing.Imaging
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode
Imports System.IO

Public Class frmQRCodeZXing

    Dim strPathImage As String = MyPath(Application.StartupPath)

    Private Sub frmQRCodeZXing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtData.Text = "www.g2gnet.com/webboard"
    End Sub

    '// Event when data is changed.
    Private Sub txtData_TextChanged(sender As Object, e As EventArgs) Handles txtData.TextChanged
        If String.IsNullOrWhiteSpace(txtData.Text) Then
            picBarcode.Image = Nothing
            Return
        End If
        '//
        Dim options As EncodingOptions = New QrCodeEncodingOptions
        With options
            .Width = picBarcode.Width
            .Height = picBarcode.Height
            .Hints.Add(ZXing.EncodeHintType.CHARACTER_SET, "UTF-8")
        End With

        Dim objWriter As BarcodeWriter = New BarcodeWriter With {
                .Format = BarcodeFormat.QR_CODE,
                .Options = options
                }

        picBarcode.Image = New Bitmap(objWriter.Write(txtData.Text))
    End Sub

    '// Save image of QR Code.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dlgSaveFile As New SaveFileDialog
        With dlgSaveFile
            .Title = "Select images"
            .Filter = "Image files (*.jpg,*.png,*bmp) | *.jpg; *.png; *.bmp"
            .FilterIndex = 1
            .RestoreDirectory = True
            .InitialDirectory = strPathImage
        End With
        '//
        If dlgSaveFile.ShowDialog() = DialogResult.OK Then
            '// Saves the Image via a FileStream created by the OpenFile method.
            Dim fs = CType(dlgSaveFile.OpenFile, FileStream)
            '// Saves the Image in the appropriate ImageFormat based upon the
            '// file type selected in the dialog box.
            Select Case dlgSaveFile.FilterIndex
                Case 1
                    picBarcode.Image.Save(fs, ImageFormat.Jpeg)
                Case 3
                    picBarcode.Image.Save(fs, ImageFormat.Png)
                Case 4
                    picBarcode.Image.Save(fs, ImageFormat.Bmp)
            End Select
            fs.Close()
            MessageBox.Show("QR Code image has been saved.")
        End If
    End Sub

    '// Load QR Code and decode it.
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim dlgImage As OpenFileDialog = New OpenFileDialog()
        ' / Open File Dialog
        With dlgImage
            '.InitialDirectory = strPath
            .Title = "Select images"
            .Filter = "Image files (*.jpg,*.png,*bmp) | *.jpg; *.png; *.bmp"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        ' Select OK after Browse ...
        If dlgImage.ShowDialog() = DialogResult.OK Then
            Using FS As IO.FileStream = File.Open(dlgImage.FileName, FileMode.Open)
                Dim bitmap As Bitmap = New Bitmap(FS)
                Dim CurrentPicture As Image = CType(bitmap, Image)
                picBarcode.Image = CurrentPicture
                '// Decode
                Dim objReader As BarcodeReader = New BarcodeReader()
                Dim objResult As Result = objReader.Decode(bitmap)
                If objResult IsNot Nothing Then
                    txtData.Text = objResult.Text
                Else
                    MessageBox.Show("Cannot decode this image!")
                End If
            End Using
        End If
    End Sub

    '// Copy to clipboard.
    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        '/ Add it as an image
        Clipboard.SetImage(picBarcode.Image)
        '/ Create a JPG on disk and add the location to the clipboard
        Dim TempName As String = "TempName.jpg"
        Dim TempPath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, TempName)
        Using FS As New System.IO.FileStream(TempPath, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Read)
            picBarcode.Image.Save(FS, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Using
        Dim Paths As New System.Collections.Specialized.StringCollection()
        Paths.Add(TempPath)
        Clipboard.SetFileDropList(Paths)
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with ""
    ' / Return : C:\My Project\
    Function MyPath(AppPath As String) As String
        '/ MessageBox.Show(AppPath);
        AppPath = AppPath.ToLower()
        '/ Return Value
        MyPath = AppPath.Replace("\bin\debug", "").Replace("\bin\release", "").Replace("\bin\x86\debug", "")
        '// If not found folder then put the \ (BackSlash ASCII Code = 92) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

End Class

