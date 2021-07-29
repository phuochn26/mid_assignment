import React from "react";
import {
    Link
} from "react-router-dom";
import "./Book.css"

const BookList = () => {
    return (
        <div>
            <div style={{ marginBottom: '10px' }}>
                <h3 class="d-inline-block">Book list</h3>
                <Link to={"/createBook"} >Add new book</Link>
            </div>
            <div>
                <table>
                    <thead>
                        <tr>
                            <th>Book Name</th>
                            <th>Category</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Lord of the ring</td>
                            <td>Adventure</td>
                            <td><Link>Edit</Link><Link style={{ marginLeft: '10px' }}>Delete</Link></td>
                        </tr>
                        <tr>
                            <td>Game of throne</td>
                            <td>Fantasy</td>
                            <td><Link>Edit</Link><Link style={{ marginLeft: '10px' }}>Delete</Link></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    )
}

export default BookList;