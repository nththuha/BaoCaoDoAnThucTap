package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemOrderdetailBinding
import com.example.ordermanagement.model.OrderDetailEntity
import java.text.DecimalFormat

class OrderDetailAdapter(private val clickListener: (OrderDetailEntity, Int) -> Unit) :
    ListAdapter<OrderDetailEntity, OrderDetailAdapter.OrderDetailEntityViewHolder>(DiffCallback) {

    class OrderDetailEntityViewHolder(private var binding: ItemOrderdetailBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(orderDetailEntity: OrderDetailEntity) {
            val dec = DecimalFormat("#,###.##")
            val money = dec.format(orderDetailEntity.gia) + "VND"
            binding.tvPrice.text = money
            if (orderDetailEntity.maLMA != "LMA11") {
                if (orderDetailEntity.trangThai != "just order") {
                    binding.btnEditDetail.setBackgroundResource(R.color.gray_dark)
                    binding.btnEditDetail.isEnabled = false
                }
            }
            binding.detail = orderDetailEntity
            binding.executePendingBindings()
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): OrderDetailEntityViewHolder {
        return OrderDetailEntityViewHolder(
            ItemOrderdetailBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: OrderDetailEntityViewHolder, position: Int) {
        val orderDetail = getItem(position)
        holder.itemView.findViewById<Button>(R.id.btnCancel_Detail).setOnClickListener {
            clickListener(orderDetail, 1)
        }
        holder.itemView.findViewById<Button>(R.id.btnEdit_Detail).setOnClickListener {
            clickListener(orderDetail, 2)
        }
        holder.bind(orderDetail)
    }


    companion object DiffCallback : DiffUtil.ItemCallback<OrderDetailEntity>() {
        override fun areItemsTheSame(
            oldItem: OrderDetailEntity,
            newItem: OrderDetailEntity
        ): Boolean {
            return oldItem.idCTDM == newItem.idCTDM
        }

        override fun areContentsTheSame(
            oldItem: OrderDetailEntity,
            newItem: OrderDetailEntity
        ): Boolean {
            return oldItem == newItem
        }
    }
}