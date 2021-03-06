﻿Imports DTO.BaocaocongnoDTO
Imports System.Data.SqlClient
Imports DAL.data
Namespace BaocaocongnoDAL
    Public Class BaocaocongnoDAL
        Dim dataaccess As New DataAccess
        'Hiển thị báo cáo
        Public Function Hienthibaocaocongno() As DataTable
            Return dataaccess.Taidulieu("select BAOCAOCONGNO.*,KHACHHANG.Hotenkhachhang from BAOCAOCONGNO,KHACHHANG where BAOCAOCONGNO.Makhachhang=KHACHHANG.Makhachhang")
        End Function
        'thêm báo cáo
        Public Function Thembaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Dim sql As String = "insert into BAOCAOCONGNO(Machitietcongno,Thang,Nam,Makhachhang,Nodau,Nophatsinh,Nocuoi) values('" & bccn.Machitietcongno.Trim & "','" & bccn.Thang & "','" & bccn.Nam & "','" & bccn.Makhachhang & "','" & bccn.Nodau & "','" & bccn.Nophatsinh & "','" & bccn.Nocuoi & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'tìm kiếm báo cáo theo tháng và năm
        Public Function Timkiembaocaocongnotheothangvanam(ByVal bccn As BaocaocongnoDTO) As DataTable
            Dim sql As String = "select BAOCAOCONGNO.*,KHACHHANG.Hotenkhachhang from BAOCAOCONGNO,KHACHHANG where Thang ='" & bccn.Thang & "' and Nam ='" & bccn.Nam & "' and BAOCAOCONGNO.Makhachhang = KHACHHANG.Makhachhang"
            Return dataaccess.Taidulieu(sql)
        End Function
        'cập nhật báo cáo
        Public Function Capnhatbaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Dim sql As String = "update BAOCAOCONGNO set Nodau='" & bccn.Nodau & "',Nophatsinh='" & bccn.Nophatsinh & "',Nocuoi='" & bccn.Nocuoi & "' where Machitietcongno = '" & bccn.Machitietcongno & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'tìm báo cáo tháng trước
        Public Function Timbaocaocongnotheothangtruoc(ByVal Makhachhang As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select * from BAOCAOCONGNO where Makhachhang='" & Makhachhang & "' and Thang='" & thang & "' and Nam='" & nam & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'xóa báo cáo theo tháng và năm
        Public Function Xoabaocaocongnotheothangvanam(ByVal thang As Integer, ByVal nam As Integer) As String
            Dim sql As String = "delete from BAOCAOCONGNO where Thang='" & thang & "' and Nam = '" & nam & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Tangmabccn() As String
            Dim sql As String = "Select * From BAOCAOCONGNO"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "BC001"
            Else
                Dim k As Integer
                ma = "BC"
                k = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0).ToString().Substring(2, 3))
                k = k + 1
                If k < 10 Then
                    ma = ma + "00"
                ElseIf k < 100 Then
                    ma = ma + "0"
                End If
                ma = ma + k.ToString()
            End If
            Return ma
        End Function
    End Class
End Namespace
