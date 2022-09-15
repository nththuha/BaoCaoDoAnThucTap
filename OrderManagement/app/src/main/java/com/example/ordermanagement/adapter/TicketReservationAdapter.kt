package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemTicketReservationBinding
import com.example.ordermanagement.model.TicketReservationEntity
import com.example.ordermanagement.ui.TicketReservationFragmentDirections

class TicketReservationAdapter(private val clickListener: (TicketReservationEntity) -> Unit) :
    ListAdapter<TicketReservationEntity, TicketReservationAdapter.TicketReservationEntityViewHolder>(
        DiffCallback
    ) {

    class TicketReservationEntityViewHolder(private var binding: ItemTicketReservationBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(ticketReservationEntity: TicketReservationEntity) {
            binding.ticket = ticketReservationEntity
            binding.executePendingBindings()

        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): TicketReservationEntityViewHolder {
        return TicketReservationEntityViewHolder(
            ItemTicketReservationBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: TicketReservationEntityViewHolder, position: Int) {
        val ticketReservation = getItem(position)

        holder.itemView.findViewById<Button>(R.id.btnOrder).setOnClickListener {
            val action =
                TicketReservationFragmentDirections.actionTicketReservationFragmentToOrderFragment()
            holder.itemView.findNavController().navigate(action)
            clickListener(ticketReservation)
        }

        holder.itemView.findViewById<Button>(R.id.btnDetail).setOnClickListener {
            val action =
                TicketReservationFragmentDirections.actionTicketReservationFragmentToDetailFragment()
            holder.itemView.findNavController().navigate(action)
            clickListener(ticketReservation)
        }

        holder.bind(ticketReservation)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<TicketReservationEntity>() {
        override fun areItemsTheSame(
            oldItem: TicketReservationEntity,
            newItem: TicketReservationEntity
        ): Boolean {
            return oldItem.idPD == newItem.idPD
        }

        override fun areContentsTheSame(
            oldItem: TicketReservationEntity,
            newItem: TicketReservationEntity
        ): Boolean {
            return oldItem == newItem
        }
    }
}