package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemTableBinding
import com.example.ordermanagement.model.TableEntity

class TableAdapter(private val clickListener: (TableEntity) -> Unit) :
    ListAdapter<TableEntity, TableAdapter.TableEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): TableAdapter.TableEntityViewHolder {
        val viewHolder = TableEntityViewHolder(
            ItemTableBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: TableAdapter.TableEntityViewHolder, position: Int) {
        val room = getItem(position)
        holder.bind(room)
    }

    class TableEntityViewHolder(private var binding: ItemTableBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(table: TableEntity) {
            if (table.trangThai == "Unavailable") {
                binding.llTable.setBackgroundResource(R.drawable.btn_room_unavailable)
                binding.llTable.isEnabled = false
            }
            binding.table = table
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<TableEntity>() {
        override fun areItemsTheSame(oldItem: TableEntity, newItem: TableEntity): Boolean {
            return oldItem.maBan == newItem.maBan
        }

        override fun areContentsTheSame(oldItem: TableEntity, newItem: TableEntity): Boolean {
            return oldItem == newItem
        }
    }
}