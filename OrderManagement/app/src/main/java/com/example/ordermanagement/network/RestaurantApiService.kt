package com.example.ordermanagement.network

import com.example.ordermanagement.model.*
import com.squareup.moshi.Moshi
import com.squareup.moshi.kotlin.reflect.KotlinJsonAdapterFactory
import okhttp3.OkHttpClient
import okhttp3.Protocol
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.moshi.MoshiConverterFactory
import retrofit2.http.*
import java.util.*
import java.util.concurrent.TimeUnit

private const val BASE_URL =
    "https://api-restaurantmanagement.herokuapp.com/api/"

private val moshi = Moshi.Builder()
    .add(KotlinJsonAdapterFactory())
    .build()

private val retrofit = Retrofit.Builder()
    .addConverterFactory(MoshiConverterFactory.create(moshi))
    .baseUrl(BASE_URL)
    .client(OkHttpClient().newBuilder().also { client ->
        val loggingInterceptor = HttpLoggingInterceptor()
        loggingInterceptor.setLevel(HttpLoggingInterceptor.Level.BODY)
        client.addNetworkInterceptor(loggingInterceptor)
        client.connectTimeout(120, TimeUnit.SECONDS)
        client.writeTimeout(120, TimeUnit.SECONDS)
        client.protocols(Collections.singletonList(Protocol.HTTP_1_1))
    }.build())
    .build()

interface RestaurantApiService {
    @GET("phong")
    suspend fun getDSPhong(): List<RoomEntity>

    @GET("ctban/{maPhong}")
    suspend fun getDSBanTheoPhong(@Path("maPhong") maPhong: String): List<TableEntity>

    @GET("loaimonan")
    suspend fun getDSLoaiMonAn(): List<TypeOfFoodEntity>

    @GET("loaimonan/{maLMA}")
    suspend fun getDSMonAnTheoLoaiMonan(@Path("maLMA") maLMA: String): List<FoodEntity>

    @POST("taikhoan")
    suspend fun kiemTraDangNhap(@Body taiKhoanEntity: TaiKhoanEntity): NhanVienEntity

    @GET("phieudat")
    suspend fun layDSPhieuDatChuaCoHoaDon(): List<TicketReservationEntity>

    @POST("phieudat")
    suspend fun themPhieuDat(@Body phieuDat: TicketReservationEntity): TicketReservationEntity

    @GET("khachhang")
    suspend fun layDSKhachHang(): List<CustomerEntity>

    @GET("ctdatmon/{idpd}")
    suspend fun layDSDatMonTheoPD(@Path("idpd") idpd: Int): List<OrderDetailEntity>

    @GET("ctdatmon/monan")
    suspend fun layDSDatMon_MonAn(): List<OrderDetailEntity>

    @GET("ctdatmon/nuocuong")
    suspend fun layDSDatMon_NuocUong(): List<OrderDetailEntity>

    @DELETE("ctdatmon/{idCTDM}")
    suspend fun xoaCTDatMon(@Path("idCTDM") idCTDM: Int): Boolean

    @POST("ctdatmon")
    suspend fun themCTDatMon(@Body ctdatmon: OrderDetailEntity): OrderDetailEntity

    @PUT("ctdatmon")
    suspend fun suaCTDatMon(@Body ctdatmon: OrderDetailEntity): OrderDetailEntity

    @PUT("monan")
    suspend fun suaMonAn(@Body monAn: FoodEntity): FoodEntity

    @GET("monan/{maMA}")
    suspend fun suaTrangThaiMonAn(@Path("maMA") maMA: String): FoodEntity
}

object RestaurantApi {
    val retrofitService: RestaurantApiService by lazy { retrofit.create(RestaurantApiService::class.java) }
}