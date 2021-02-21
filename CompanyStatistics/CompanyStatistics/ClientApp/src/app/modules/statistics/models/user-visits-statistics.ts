import { Section } from "src/app/models/section";
import { User } from "src/app/models/user";

export interface UserVisitsStatistics {
    user: User,
    totalVisitsCount: number,
    favoriteSection: Section
}
