import React from "react";
import {
    Link
  } from "react-router-dom";
import "./Book.css"

const CreateBook = () => {
    return (
        <div>
            <div>
                <h3 class="d-inline-block">Create Book</h3>
              <Link to="/book">Back to list</Link>
            </div>
            <div>
                <div>
                    <label>Book Name</label>
                    <input type="text"></input>
                </div>
                <div>
                    <label>Release Date</label>
                    <input type="date"></input>
                </div>
                <div>
                    <label>Category</label>
                    <select id="CategoryId">
                        <option value="action">Action</option>
                        <option value="drama">Drama</option>
                    </select>
                </div>
            </div>
        </div>
    )
}

export default CreateBook;