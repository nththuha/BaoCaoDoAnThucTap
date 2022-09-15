package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemKitchenBinding
import com.example.ordermanagement.model.OrderDetailEntity

class KitchenAdapter(private val clickListener: (OrderDetailEntity, Int) -> Unit) :
    ListAdapter<OrderDetailEntity, KitchenAdapter.OrderDetailEntityViewHolder>(DiffCallback) {

    class OrderDetailEntityViewHolder(private var binding: ItemKitchenBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(detail: OrderDetailEntity) {
            binding.detail = detail
            if (detail.chuThich == null) {
                binding.tvNote.text = "Note: "
            } else binding.tvNote.text = "Note: " + detail.chuThich
            if (detail.trangThai == "doing") {
                binding.btnDoing.setBackgroundResource(R.color.gray_dark)
                binding.btnDoing.isEnabled = false
            }
            binding.executePendingBindings()
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): OrderDetailEntityViewHolder {
        return OrderDetailEntityViewHolder(
            ItemKitchenBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: OrderDetailEntityViewHolder, position: Int) {
        val detail = getItem(position)
        holder.itemView.findViewById<Button>(R.id.btnDoing).setOnClickListener {
            clickListener(detail, 1)
        }
        holder.itemView.findViewById<Button>(R.id.btnDone).setOnClickListener {
            clickListener(detail, 2)
        }
        holder.itemView.findViewById<Button>(R.id.btnCancel_Nau).setOnClickListener {
            clickListener(detail, 3)
        }
        holder.bind(detail)
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